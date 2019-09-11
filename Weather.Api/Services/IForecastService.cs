namespace Weather.Api.Services
{
    using System;
    using System.Collections.Generic;
    using Weather.Api.Models;

    public interface IForecastService
    { 
        IEnumerable<Forecast> GetForecast(int days, string[] stations);
    }
}
