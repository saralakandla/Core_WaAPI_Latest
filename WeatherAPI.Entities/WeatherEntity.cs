using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherAPI.Entities
{
    public class WeatherEntity
    {
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("temperature")]
        public int Temperature { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("windSpeed")]
        public int WindSpeed { get; set; }


        [JsonProperty("weatherIconDesc")]
        public string WeatherIconDesc { get; set; }
        [JsonProperty("weatherIconId")]
        public int WeatherIconId { get; set; }


        public WeatherEntity(string city, DateTime date, int temperature, int humidity, int windSpeed, string iconDesc, int icon)
        {
            City = city;
            Date = date;
            Temperature = temperature;
            Humidity = humidity;
            WindSpeed = windSpeed;
            WeatherIconDesc = iconDesc;
            WeatherIconId = icon;
        }
    }
}