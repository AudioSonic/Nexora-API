namespace Nexora.Api.Middleware
{
    public class NexoraMiddleware
    {
        private readonly RequestDelegate _next;

        public NexoraMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("Request kommt an");

            await _next(context);

            Console.WriteLine("Response kommt zurück");
        }
    }
}
