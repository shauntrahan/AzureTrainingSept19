namespace Weather.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Actual", Schema = "Weather")]
    public class Actual
    {
        [Key]
        public int WeatherActualId { get; set; }
        public int ICAO_Id { get; set; }
        public DateTime WeatherDate { get; set; }
        public byte? HE { get; set; }
        public decimal Temperature { get; set; }
        public decimal? Humidity { get; set; }
        public decimal? DewPoint { get; set; }

        public WeatherStation WeatherStation { get; set; }
    }
}
