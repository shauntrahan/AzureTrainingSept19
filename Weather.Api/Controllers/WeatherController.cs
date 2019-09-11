namespace Weather.Api.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Weather.Api.Models;
    using Weather.Api.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IForecastService forecastService;

        public WeatherController(IForecastService forecastService)
        {
            this.forecastService = forecastService;
        }

        // GET api/weather/forecast
        [HttpGet("forecast")]
        public ActionResult<IEnumerable<Forecast>> GetForecast([FromQuery]int days, [FromQuery]string[] stations)
        {
            return new ActionResult<IEnumerable<Forecast>>(forecastService.GetForecast(days, stations));
        }
    }
}
