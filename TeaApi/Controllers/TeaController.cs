using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace TeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
            "Black", "Green", "Assam"
        };

        private readonly ILogger<TeaController> _logger;

        public TeaController(ILogger<TeaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Teas[rng.Next(Teas.Length)]);

        }
    }
}
