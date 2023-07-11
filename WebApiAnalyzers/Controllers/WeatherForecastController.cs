using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace WebApiAnalyzers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("endpoint-1")]
        public IActionResult Endpoint1()
        {
            GC.Collect();
            return Ok();
        }

        [HttpGet("endpoint-2")]
        public IActionResult Endpoint2()
        {
            int sec = DateTime.Now.Second;

            if (sec % 2 == 0)
            {
                return Ok();
            }
            else if (sec % 3 == 0)
            {
                return BadRequest();
            }

            return Ok();
        }


        [HttpGet("path/{path}")]
        public IActionResult PathInjection(string path)
        {
            using (System.IO.File.Open(path, FileMode.Open))
            {
                // Read a file with the name supplied by user
                // Input through request's query string and display
                // The content to the webpage.
            }
            return Ok();
        }

        [HttpGet("hash")]
        public IActionResult Hash()
        {
            using var hash = MD5.Create();
            return Ok();
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}