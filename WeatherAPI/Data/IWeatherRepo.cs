using System;
using System.Collections.Generic;
using WeatherAPI.Models;

namespace WeatherAPI.Data
{
    public interface IWeatherRepo
    {
        IEnumerable<WeatherItem> GetAllElements();
        WeatherItem GetElementById(Guid id);
    }
}
