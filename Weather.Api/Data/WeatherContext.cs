namespace Weather.Api.Data
{
    using Microsoft.EntityFrameworkCore;
    using Weather.Api.Models;

    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options)
            : base(options)
        { }

        public DbSet<FifteenDayForecast> FifteenDayForecasts { get; set; }

        public DbSet<WeatherStation> WeatherStations { get; set; }

        public DbSet<Actual> Actuals { get; set;}
    }
}
