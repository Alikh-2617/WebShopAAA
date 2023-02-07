using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebShopAAA.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MService
    {
        private readonly RequestDelegate _next;

        public MService(RequestDelegate next)
        {
            _next = next;
        }


        public  Task Invoke(HttpContext httpContext)
        {
            // innan next är för request
            return   _next(httpContext);  // efter next är respons
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MServiceExtensions
    {
        public static IApplicationBuilder UseMService(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MService>();
        }
    }
}
