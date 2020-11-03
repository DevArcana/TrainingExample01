using Microsoft.AspNetCore.Mvc;
using MyWebApp.Services;

namespace MyWebApp.Controllers
{
    [Route("api/greetings")]
    [ApiController]
    public class GreetingsController : ControllerBase
    {
        private readonly IGreeter _greeter;

        public GreetingsController(IGreeter greeter)
        {
            _greeter = greeter;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_greeter.GetGreeting());
        }
    }
}