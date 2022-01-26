using aplus_back_seed.Interfaces;
using aplus_back_seed.Models;
using Microsoft.AspNetCore.Mvc;

namespace aplus_back_seed.Controllers;
[LogStatus]
[ApiController]
[Route("[controller]/[action]")]
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
       return  _data.GetUsers(new AplusRequestListParams{
           page = 1, 
           pageSize = 20
       });
    }

    [Authenticate]
    [HttpPost(Name = "Newuser")]
    public String NewUser(User user)
    {
       return "ok";
    }
}
