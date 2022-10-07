using System;
using System.Collections.Generic;
using System.Linq;
using WeatherAPI.Models;
using WeatherAPI.Enums;

namespace WeatherAPI.Data
{
    public class MockWeatherRepo : IWeatherRepo
    {
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

        public void CreateElement(WeatherItem item)
        {
            throw new NotImplementedException();
        }

        public void DeleteElement(WeatherItem item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<WeatherItem> GetAllElements()
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

        public WeatherItem GetElementById(Guid id)
        {
            var rng = new Random();
            WeatherItem i = new WeatherItem
            {
                Id = id,
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
            };

            return i;
        }

        public string CombineIntegers(int a, int b)
        {
            //string str = a + "." + b;
            //return str;

            return a + "." + b;
        }

        public void UpdateElement(WeatherItem item)
        {
            throw new NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
