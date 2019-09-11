using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Weather.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                Temperature = rng.Next(-20, 55),
                Humidity = rng.Next(70, 100),
                DewPoint = rng.Next(-20, 55)
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int Temperature { get; set; }
            public int Humidity { get; set; }
            public int DewPoint { get; set; }
        }
    }
}
