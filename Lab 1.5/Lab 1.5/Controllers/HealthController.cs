using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab_1._5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok(new { status = "Ok" });
        }

        [HttpGet("ready")]
        public IActionResult Ready()
        {
            if (ReadyChecker.IsReady)
                return Ok("ready");

            return BadRequest();
        }

        [HttpGet("live")]
        public IActionResult Live()
        {
            return Ok("live");
        }
    }
}
