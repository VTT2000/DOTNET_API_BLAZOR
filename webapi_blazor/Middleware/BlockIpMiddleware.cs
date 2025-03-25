using System;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace webapi_blazor.Middleware
{
   
    // REMEMBER: Add `services.AddTransient<NameMiddleware>();` to Startup.ConfigureServices() method
    public class BlockIpMiddleware : IMiddleware
    {
        // IMiddleware is activated per request, 
        // so scoped services can be injected into the middleware's constructor.
        public BlockIpMiddleware()
        {
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status400BadRequest;

            var result = new { message = "Something went wrong" };
            await context.Response.WriteAsync(JsonSerializer.Serialize(result));
            
            // await next(context);
        }
    }
}
