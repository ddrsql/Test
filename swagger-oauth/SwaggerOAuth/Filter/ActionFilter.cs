using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerOAuth
{
    public class ActionFilter : IActionFilter, IOrderedFilter
    {
        //private readonly ILogger _logger;

        //public ActionFilter(ILogger<ActionFilter> logger)
        //{
        //    _logger = logger;
        //}

        public string Name { get; set; }

        public int Order { get; set; } = 0;

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //_logger.LogInformation($"out-{GetType().Name}  {DateTime.Now}");
            Console.WriteLine($"out-{GetType().Name}  {DateTime.Now}. \r\n");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            //_logger.LogInformation($"in-{GetType().Name}  {DateTime.Now}");
            Console.WriteLine($"in-{GetType().Name}  {DateTime.Now}. \r\n");
            //Thread.Sleep(1000);
            ModelStateDictionary modelState = context.ModelState;
            if (!modelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(modelState);
            }
        }
    }
}
