var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bookstore}/{action=index}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Bookstore}/{action=Aboutus}");

app.Run();