namespace Middlewares.MyMiddleware
{
    public class MyMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            //throw new NotImplementedException();
            await context.Response.WriteAsync("\nContent Part 1");
            await context.Response.WriteAsync("\nContent Part 2");
            await next(context);
            await context.Response.WriteAsync("\nMiddleware's work is finished....");
        }
    }
}


