using aplus_back_seed.Interfaces;

namespace aplus_back_seed.Common
{
    public class AplusMockDataAccesses : IAplusDataAccesses
    {
        private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        IEnumerable<WeatherForecast> IAplusDataAccesses.getWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
       .ToArray();
        }
    }
}