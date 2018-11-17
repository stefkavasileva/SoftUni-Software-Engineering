using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace BookLibrary.Web.Filters
{
    public class LogExecution : IPageFilter, IActionFilter
    {
        private ILogger logger;
        private Stopwatch watch;
        public LogExecution(ILogger<LogExecution> logger, Stopwatch match)
        {
            this.logger = logger;
            this.watch = watch;
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            this.LogExecutingMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName, context.ModelState.IsValid);
        }

        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            this.LogExecutedMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            this.LogExecutingMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName, context.ModelState.IsValid);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            this.LogExecutedMessage(context.HttpContext.Request.Method, context.ActionDescriptor.DisplayName);
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {

        }

        public void LogExecutingMessage(string method, string action, bool isValid)
        {
            this.watch = new Stopwatch();
            this.logger.LogInformation($"Executing {method} {action}");

            var isValidValue = isValid ? "valid" : "invalid";
            this.logger.LogInformation($"Model state {isValidValue}");

            this.watch.Reset();
        }

        public void LogExecutedMessage(string method, string action)
        {
            this.watch.Stop();
            this.logger.LogInformation($"Executed {method}.{action} in {watch.Elapsed.TotalSeconds}");
        }
    }
}
