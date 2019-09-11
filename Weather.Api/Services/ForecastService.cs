namespace Weather.Api.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Weather.Api.Models;
    using Weather.Api.Data;
    using Microsoft.EntityFrameworkCore;

    public class ForecastService: IForecastService
    {
        private WeatherContext weatherDbContext;

        public ForecastService(WeatherContext weatherContext)
        {
            this.weatherDbContext = weatherContext;
        }

        public IEnumerable<Forecast> GetForecast(int days, string[] stations)
        {
            IEnumerable<FifteenDayForecast> forecastData = new List<FifteenDayForecast>();

            if (stations == null || stations.Length == 0)
            {
                forecastData = this.weatherDbContext.FifteenDayForecasts.Include(f => f.WeatherStation).Where(f => f.WeatherDate.AddDays(days) <= DateTime.Today).ToList();
            }
            else
            {
                forecastData = this.weatherDbContext.FifteenDayForecasts.Include(f => f.WeatherStation).Where(f => stations.Contains(f.WeatherStation.ICAO) && f.WeatherDate.AddDays(days) <= DateTime.Today).ToList();
            }

            return from f in forecastData
                   orderby f.WeatherStation.ICAO, f.WeatherDate, f.HE
                   select new Forecast
                   {
                       WeatherStation = f.WeatherStation.ICAO,
                       WeatherDate = f.WeatherDate,
                       HourEnding = f.HE.HasValue ? f.HE.Value : 0,
                       Temperature = f.Temperature,
                       Humidity = f.Humidity.HasValue ? f.Humidity.Value : 0m,
                       DewPoint = f.DewPoint.HasValue ? f.DewPoint.Value : 0m
                   };
        }
    }
}
