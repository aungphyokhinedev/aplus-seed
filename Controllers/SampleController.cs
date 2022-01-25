using aplus_back_seed.Interfaces;
using aplus_back_seed.Models;
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

    
    [HttpGet(Name = "GetUsers")]
    public AplusListData<User> GetUsers()
    {
       return  _data.GetUsers();
    }
}
