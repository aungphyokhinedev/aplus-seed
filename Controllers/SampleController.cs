using aplus_back_seed.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aplus_back_seed.Controllers;

[ApiController]
[Route("[controller]")]
public class SampleController : AplusBasedController
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public SampleController(IAplusSample sample, ILogger<AplusBasedController> logger) : base(sample, logger)
    {
    }

    [HttpGet(Name = "GetSample")]
    public IEnumerable<WeatherForecast> Get()
    {
        _sample.write("testing di");
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
