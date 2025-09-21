using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWeatherApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild",
            "Warm", "Balmy", "Hot", "Sweltering", "Scorching", "Rainy", "Sunny"
        };

        public Task<WeatherForecast[]> GetForecastAsync()
        {
            var rng = new Random();
            var forecasts = Enumerable.Range(0, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-5, 35),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray();

            return Task.FromResult(forecasts);
        }
    }
}
