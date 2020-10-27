using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CoffeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "lungo", "espresso", "ristretto"
        };

        private readonly ILogger<CoffeeController> _logger;

        public CoffeeController(ILogger<CoffeeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();
            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}
