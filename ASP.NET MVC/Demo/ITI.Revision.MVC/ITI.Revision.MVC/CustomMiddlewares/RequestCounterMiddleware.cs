namespace ITI.Revision.MVC.CustomMiddlewares
{
    public class RequestCounterMiddleware
    {
        private readonly RequestDelegate _next;
        private static int requestCount = 0;

        public RequestCounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Increment the request count
            requestCount++;

            // Log the request and the total count
            Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}, Total Requests: {requestCount}");

            // Disable browser caching
            context.Response.Headers["Cache-Control"] = "no-cache, no-store, must-revalidate";
            context.Response.Headers["Pragma"] = "no-cache";
            context.Response.Headers["Expires"] = "0";

            // Call the next middleware in the pipeline
            await _next.Invoke(context);

        }

    }
}
