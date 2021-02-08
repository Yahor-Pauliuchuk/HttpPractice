using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace LessonOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static IList<WeatherForecast> weatherForecasts
            = new List<WeatherForecast>
        {
            new WeatherForecast
            {
                Date = new DateTime(2020, 02, 10),
                TemperatureC = 20,
                Summary = Summary.Warm,
                City = "Brest"
            },
            new WeatherForecast
            {
                Date = new DateTime(2020, 02, 10),
                TemperatureC = 14,
                Summary = Summary.Mild,
                City = "Vitebsk"
            }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(weatherForecasts);
        }

        [HttpPost]
        public IActionResult Post(WeatherForecast newForecast)
        {
            weatherForecasts.Add(newForecast);

            return Created(string.Empty, newForecast);
        }
    }
}