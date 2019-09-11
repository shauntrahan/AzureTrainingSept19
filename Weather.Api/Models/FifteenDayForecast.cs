namespace Weather.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("15DayForecast", Schema = "Weather")]
    public class FifteenDayForecast
    {
        [Key]
        public int Weather15DayForecastId { get; set; }
        public int ICAO_Id { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime WeatherDate { get; set; }
        public byte? HE { get; set; }
        public decimal Temperature { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? DewPoint { get; set; }

        public WeatherStation WeatherStation { get; set; }
    }
}
