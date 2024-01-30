using CollectiHaven.BusinessLogic;
using CollectiHaven.DataAccess;
using CollectiHaven.DataAccess.EntityFramework;
using CollectiHaven.WebApp.Code;
using CollectiHaven.WebApp.Code.ExtensionMethods;
using Microsoft.EntityFrameworkCore;
using Stripe;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add services to the container.

var connectionString = builder.Configuration["ConnectionString"];
object value = builder.Services.AddDbContext<CollectiHavenContext>(options =>
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

builder.Services.AddCollectiHavenCurrentUser();

builder.Services.AddPresentation();
builder.Services.AddCollectiHavenBusinessLogic();

builder.Services.AddAuthentication("CollectiHavenCookies")
       .AddCookie("CollectiHavenCookies", options =>
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

StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<CollectiHaven.BusinessLogic.Implementation.Hubs.NotificationHub>("/notificationHub");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
