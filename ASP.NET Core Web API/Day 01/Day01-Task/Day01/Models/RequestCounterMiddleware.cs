namespace Day01.Models
{
    public class RequestCounterMiddleware
    {
        private readonly RequestDelegate _next;
        private static int _requestCount = 0;

        public RequestCounterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Interlocked.Increment(ref _requestCount); // Increment the request count in a thread-safe way
            await _next(context);
        }

        public static int GetRequestCount()
        {
            return _requestCount;
        }

    }
}
