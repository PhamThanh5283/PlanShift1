using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using PlanShift.Models;
using PlanShift.Models.DB;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;

namespace PlanShift.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EmsSftContext _context;

        public HomeController(ILogger<HomeController> logger,EmsSftContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var multimodels = new MultiModels();
            multimodels.TimeShifts = _context.TimeShifts.GroupBy( x => x.PlanShift ).Select( g => g.First()).ToList();
            multimodels.planShifts = _context.PlanShifts.ToList();
            return View(multimodels);
        }
        [HttpPost]
        public async Task<IActionResult> Register(List<string> _PlanShift,DateTime SDate,DateTime EDate) 
        {
            if (_PlanShift.Count > 0) 
            {
                foreach (var Shiftplan in _PlanShift)
                {
                    TimeSpan Time = EDate - SDate;
                    int D = Time.Days;
                    var items = _context.TimeShifts.Where(x => x.PlanShift == Shiftplan).ToList();
                    if (EDate < SDate)
                    {
                        TempData["Checkdate"] = "True";
                    }
                    else
                    {
                        for (int i = 0; i <= D; i++)
                        {
                            var _Plandate = SDate.AddDays(i);
                            //TempData["Diff"] = SDate.AddDays(i);
                            if (_context.PlanShifts.Any(o => o.PlanDate == _Plandate && o.PlanShift1 == Shiftplan))
                            {
                                TempData["Reg"] = "Fail";
                                break;
                            }
                            else
                            {
                                foreach (var item in items)
                                {
                                    var PS = new PlanShift.Models.DB.PlanShift()
                                    {
                                        PlanDate = _Plandate,
                                        ActualDate = _Plandate.AddDays(Convert.ToInt32(item.D1)),
                                        PlanShift1 = Shiftplan,
                                        StartTime = item.StartTime,
                                        EndTime = item.EndTime,
                                    };
                                    _context.Add(PS);
                                }
                                TempData["Reg"] = "Success";
                            }
                        }
                    }
                }    
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
            ///* Check duplcate primary key in sql 
            ////catch(Exception e)
            ////{

            ////    if (e is DbUpdateException)
            ////    {
            ////        var number = (int)e.InnerException.GetType().GetProperty("Number").GetValue(e.InnerException);
            ////        if (number != null && (number == 2627 || number == 2601))
            ////        {
            ////            TempData["Reg"] = "Fail";
            ////        }      
            ////    }                      
            ////}*/
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromBody] List<DeleteModel> deleteModels)
        {
            if (deleteModels.Count > 0)
            {
                foreach (var Ps in deleteModels)
                {

                    var f = _context.PlanShifts.Where(x => x.PlanDate == DateTime.ParseExact(Ps.plandate,"dd-MM-yyyy", CultureInfo.InvariantCulture) && x.PlanShift1 == Ps.planshift).ToList();
                    foreach (var p in f)
                    {
                        _context.PlanShifts.Remove(p);
                    }
                }
                await _context.SaveChangesAsync();
                return Ok(deleteModels);
                
            }
            return BadRequest("Data null");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}