using Emulair.DataAccess;
using Emulair.WebApp.Code;
using Emulair.BusinessLogic.Base;
using Microsoft.EntityFrameworkCore;
using EmulairWeb.Context;
using Emulair.WebApp.Code.ExtensionMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add services to the container.

var connectionString = builder.Configuration["ConnectionString"];
object value = builder.Services.AddDbContext<EmulairWEBContext>(options =>
        options.UseSqlServer(connectionString));

//builder.Configure.AddConfiguration((hostingContext, config) =>
//{
//    config.SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
//          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
//          .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: true)
//          .AddEnvironmentVariables();
//});

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(1800);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddEmulairCurrentUser();

builder.Services.AddPresentation();
builder.Services.AddEmulairBusinessLogic();

builder.Services.AddAuthentication("EmulairCookies")
       .AddCookie("EmulairCookies", options =>
       {
           options.AccessDeniedPath = new PathString("/Home/Index");
           options.LoginPath = new PathString("/Account/Login");
       });

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add(typeof(GlobalExceptionFilterAttribute));
});
builder.Services.AddAutoMapper(options =>
{
    options.AddMaps(typeof(Program), typeof(BaseService));
});
builder.Services.AddScoped<UnitOfWork>();

builder.Services.AddSignalR();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
