namespace PlanShift.Models
{
    public class MultiModels
    {
        public IEnumerable<PlanShift.Models.DB.TimeShift> TimeShifts { get; set; }
        public IEnumerable<PlanShift.Models.DB.PlanShift> planShifts { get; set; }
    }
}
