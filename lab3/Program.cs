var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // bật MVC

var app = builder.Build();

app.UseStaticFiles(); // cho phép đọc file ảnh, css, js trong wwwroot

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Index}/{id?}"); // trỏ mặc định vào Customer/Index

app.Run();
