//Q11
//var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddControllers();
//var app = builder.Build();

//app.MapControllerRoute(
//    name: "ProductInfo",
//    pattern: "Productinfo/Product/{id}",
//    defaults: new { controller = "Productinfo", action = "Product" });

//app.Run();
//---

//Q12
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

app.MapControllers();
app.Run();