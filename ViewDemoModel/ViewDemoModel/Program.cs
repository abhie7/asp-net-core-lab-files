var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=Index}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=AboutUs}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Home}/{action=ContactUs}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Student}/{action=Index}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller=Student}/{action=Details}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller = Student}/{action=Edit}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{Controller = Student}/{action=Delete}"
    );

app.Run();