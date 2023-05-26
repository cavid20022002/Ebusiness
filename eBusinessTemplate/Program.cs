using eBusinessTemplate.DAL;
using eBusinessTemplate.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
//{
//    options.Password.RequireNonAlphanumeric = false;
//    options.Password.RequiredLength = 8;

//    options.User.RequireUniqueEmail = false;
//    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1);
//    options.Lockout.MaxFailedAccessAttempts = 3;
//    options.Lockout.AllowedForNewUsers = true;
//}).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

//builder.Services.AddScoped<LayoutService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt=>
opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

var app = builder.Build();

app.MapControllerRoute(
    name: "Default",
    pattern: "{area:exists}/{controller=dashboard}/{action=index}/{id?}"
    );

app.MapControllerRoute(
    name:"Default",
    pattern:"{controller=home}/{action=index}/{id?}"
    );

app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.UseRouting();

app.Run();
