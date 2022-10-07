using System;
using WeatherAPI.Enums;

namespace WeatherAPI.Models
{
    public class WeatherItem
    {
        public Guid Id { get; set; }
        public timeOfDay TimeOfDay { get; set; }
        public day Day { get; set; }
        public sunriseTime SunriseTime { get; set; }
        public sunsetTime SunsetTime { get; set; }
        public int ChanceOfRainPerсent { get; set; }
        public int HumidityPerсent { get; set; }
        public int WindSpeedKmH { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public int TemperatureCFeelsLike { get; set; }
        public int TemperatureFFeelsLike => 32 + (int)(TemperatureCFeelsLike / 0.5556);
        public string PrecipitationSm { get; set; }
        public int PressureGPa { get; set; }
        public string VisibilityKm { get; set; }
    }
}
