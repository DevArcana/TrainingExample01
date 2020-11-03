using Microsoft.Extensions.Logging;

namespace MyWebApp.Services
{
    public class Greeter : IGreeter
    {
        private readonly ILogger<Greeter> _logger;

        public Greeter(ILogger<Greeter> logger)
        {
            _logger = logger;
        }

        public string GetGreeting()
        {
            _logger.LogInformation("Retrieved greeting!");
            return "Hello";
        }
    }
}