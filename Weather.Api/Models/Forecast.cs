using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Api.Models
{
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
