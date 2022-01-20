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

    public SampleController(IAplusSample sample, ILogger<AplusBasedController> logger, IAplusDataAccesses data) : base(sample, logger, data)
    {
    }

    [HttpGet(Name = "GetSample")]
    public IEnumerable<WeatherForecast> Get()
    {
        _sample.write("testing di");
        return _data.getWeather();
    }
}
