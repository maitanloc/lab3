var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // bật MVC

var app = builder.Build();

app.UseStaticFiles(); // serve wwwroot (css, images)

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Phone}/{action=Index}/{id?}");

app.Run();
