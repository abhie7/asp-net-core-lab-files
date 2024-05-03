using Middlewares.MyMiddleware;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyMiddleware>();
var app = builder.Build();

//app.MapGet("/", () => "Abhie Sexy Boi");

app.Use(async (HttpContext context, RequestDelegate next) => //Use, next
{
    await context.Response.WriteAsync("Header Part");
    await next(context); //next method
}
);

app.Use(async (HttpContext context, RequestDelegate next) => //Use, next
{
    await context.Response.WriteAsync("\n\n\n");
    await next(context); //next method
}
);

//Chaining/Multiple Middleware
//app.Use(async (HttpContext context, RequestDelegate next) => //Use, next
//{
//    await context.Response.WriteAsync("Header Part");
//    await next(context); //next method
//}
//); //no app.Run()

app.UseMiddleware<MyMiddleware>();

//Single middleware
app.Run(async (HttpContext context) => //creating an object to pass the request
{
    await context.Response.WriteAsync("Student Management System"); //getting the response
}
);
app.Run();

