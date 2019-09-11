namespace Weather.Api.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WeatherStation", Schema = "Weather")]
    public class WeatherStation
    {
        [Key]
        public int ICAO_Id { get; set; }
        public string ICAO { get; set; }
        public string Comments { get; set; }
        public bool? Is_in_Use { get; set; }
        public bool? Has_Full_Data { get; set; }
    }
}
