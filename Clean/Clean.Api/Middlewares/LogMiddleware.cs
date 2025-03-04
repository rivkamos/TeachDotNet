namespace Clean.Api.Middlewares
{
    public class LogMiddleware
    {

        private readonly RequestDelegate _next;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // לוג של בקשה נכנסת
            Logger.Info($"Incoming request: {context.Request.Method} {context.Request.Path}");

            // המשך ל-Middleware הבא
            await _next(context);

            // לוג של בקשה יוצאת
            Logger.Info($"Outgoing response: {context.Response.StatusCode}");
        }
    }
}
