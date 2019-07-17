using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CustomMiddleware.Middlewares
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public LoggerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger("LoggerMiddleware");
        }

        public Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("Rijvy");
            return _next(httpContext);
        }
    }
}
