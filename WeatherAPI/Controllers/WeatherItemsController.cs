using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using WeatherAPI.Enums;
using WeatherAPI.Models;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherItemsController : ControllerBase
    {
        private readonly ILogger<WeatherItemsController> _logger;

        public WeatherItemsController(ILogger<WeatherItemsController> logger)
        {
            _logger = logger;
        }

        public timeOfDay TimeOfDayRandom()
        {
            Array values = Enum.GetValues(typeof(timeOfDay));
            Random random = new Random();
            timeOfDay randomTime = (timeOfDay)values.GetValue(random.Next(values.Length));
            return randomTime;
        }

        public day DayRandom()
        {
            Array values = Enum.GetValues(typeof(day));
            Random random = new Random();
            day randomDay = (day)values.GetValue(random.Next(values.Length));
            return randomDay;
        }

        public sunriseTime SunriseTimeRandom()
        {
            Array values = Enum.GetValues(typeof(sunriseTime));
            Random random = new Random();
            sunriseTime randomSunriseTime = (sunriseTime)values.GetValue(random.Next(values.Length));
            return randomSunriseTime;
        }

        public sunsetTime SunsetTimeRandom()
        {
            Array values = Enum.GetValues(typeof(sunsetTime));
            Random random = new Random();
            sunsetTime randomSunsetTime = (sunsetTime)values.GetValue(random.Next(values.Length));
            return randomSunsetTime;
        }

        public int ChanceOfRainPerсentRandom()
        {
            Random rand = new Random();
            int value = rand.Next(0, 100);
            return value;
        }

        public int HumidityPerсentRandom()
        {
            Random rand = new Random();
            int value = rand.Next(0, 100);
            return value;
        }

        public int WindSpeedKmHRandom()
        {
            Random rand = new Random();
            int value = rand.Next(0, 50);
            return value;
        }

        public string CombineIntegers(int a, int b)
        {
            string str = a + "." + b;
            return str;
        }

        public string PrecipitationSmRandom()
        {
            Random rand = new Random();
            int integerPart = rand.Next(0, 10);
            int portion = rand.Next(0, 99);
            string result = CombineIntegers(integerPart, portion);
            return result;
        }

        public int PressureGPaRandom()
        {
            Random rand = new Random();
            int value = rand.Next(973, 1040);
            return value;
        }

        public string VisibilityKmRandom()
        {
            Random rand = new Random();
            int integerPart = rand.Next(1, 12);
            int portion = rand.Next(0, 99);
            string result = CombineIntegers(integerPart, portion);
            return result;
        }

        [HttpGet]
        public IEnumerable<WeatherItem> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherItem
            {
                Id = Guid.NewGuid(),
                TimeOfDay = TimeOfDayRandom(),
                Day = DayRandom(),
                SunriseTime = SunriseTimeRandom(),
                SunsetTime = SunsetTimeRandom(),
                ChanceOfRainPerсent = ChanceOfRainPerсentRandom(),
                HumidityPerсent = HumidityPerсentRandom(),
                WindSpeedKmH = WindSpeedKmHRandom(),
                TemperatureC = rng.Next(-20, 55),
                TemperatureCFeelsLike = rng.Next(-20, 55) - 5,
                PrecipitationSm = PrecipitationSmRandom(),
                PressureGPa = PressureGPaRandom(),
                VisibilityKm = VisibilityKmRandom()
            })
            .ToArray();
        }

        [HttpGet("{id}")]
        public IEnumerable<WeatherItem> GetElementById(Guid id)
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherItem
            {
                Id = Guid.NewGuid(),
                TimeOfDay = TimeOfDayRandom(),
                Day = DayRandom(),
                SunriseTime = SunriseTimeRandom(),
                SunsetTime = SunsetTimeRandom(),
                ChanceOfRainPerсent = ChanceOfRainPerсentRandom(),
                HumidityPerсent = HumidityPerсentRandom(),
                WindSpeedKmH = WindSpeedKmHRandom(),
                TemperatureC = rng.Next(-20, 55),
                TemperatureCFeelsLike = rng.Next(-20, 55) - 5,
                PrecipitationSm = PrecipitationSmRandom(),
                PressureGPa = PressureGPaRandom(),
                VisibilityKm = VisibilityKmRandom()
            })
            .ToArray();
        }
    }
}
