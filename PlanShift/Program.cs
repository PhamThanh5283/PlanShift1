using Microsoft.EntityFrameworkCore;
using PlanShift.Models.DB;
using Microsoft.AspNetCore.Identity;
using PlanShift.Data;
using PlanShift.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<EmsSftContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddDefaultIdentity<PlanShiftUserIdentity>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<PlanShiftIdentityContext>();
builder.Services.AddDbContext<PlanShiftIdentityContext>(f => f.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
builder.Services.ConfigureApplicationCookie(options =>
{
    options.Cookie.HttpOnly = true;
   // options.ExpireTimeSpan = TimeSpan.FromMinutes(1);
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
    options.SlidingExpiration = true;
});


builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();
app.MapRazorPages();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
