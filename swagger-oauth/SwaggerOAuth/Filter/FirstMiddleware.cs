using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerOAuth
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //await context.Response.WriteAsync($"{nameof(FirstMiddleware)} in. \r\n");
            Console.WriteLine($"{nameof(FirstMiddleware)} in. \r\n");

            await _next(context);

            Console.WriteLine($"{nameof(FirstMiddleware)} out. \r\n");
            //ExceptionMiddleware 拦截
            //throw new Exception("Middleware 异常");
        }
    }
}
