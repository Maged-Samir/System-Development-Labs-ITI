using Microsoft.AspNetCore.Mvc.Filters;

namespace ITI.Revision.MVC.Filters
{
    public class ExecutionTimeFilter : IActionFilter
    {
        private DateTime startTime;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            startTime = DateTime.Now;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            TimeSpan executionTime = DateTime.Now - startTime;
            string controllerName = context.Controller.GetType().Name;
            string actionName = context.ActionDescriptor.DisplayName;

            Console.WriteLine($"Action '{actionName}' in controller '{controllerName}' executed in {executionTime.TotalMilliseconds} ms.");
        }
    }
}
