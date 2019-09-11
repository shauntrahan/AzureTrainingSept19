namespace Weather.Api.Models
{
    using System;

    public class Forecast
    {
        public string WeatherStation { get; set; }
        public DateTime WeatherDate { get; set; }
        public int HourEnding { get; set; }
        public decimal Temperature { get; set; }
        public decimal Humidity { get; set; }
        public decimal DewPoint { get; set; }
    }
}
