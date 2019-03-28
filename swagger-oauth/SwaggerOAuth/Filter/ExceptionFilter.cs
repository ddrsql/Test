using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SwaggerOAuth
{
    public class ExceptionFilter : IExceptionFilter
    {
        //private readonly ILogger _logger;

        //public ExceptionFilter(ILogger<ExceptionFilter> logger)
        //{
        //    _logger = logger;
        //}

        public void OnException(ExceptionContext context)
        {
            //_logger.LogInformation($"in-{GetType().Name}  {DateTime.Now}");
            Console.WriteLine($"in-{GetType().Name}  {DateTime.Now}. \r\n");
            //Thread.Sleep(1000);
        }
    }
}
