var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
    //name: "home",
    //pattern: "home/{action}",
    //defaults: new { controller = "home", action = "Index" }); // Default to Index action if action is not specified
app.Run();
