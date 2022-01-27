using aplus_back_seed.Interfaces;
using aplus_back_seed.Models;
using System.Linq.Dynamic.Core;
namespace aplus_back_seed.Common
{
    public class AplusMockDataAccesses : IAplusDataAccesses
    {
         private readonly AplusContext _context; 
         public AplusMockDataAccesses(AplusContext context)  
        {  
            _context = context;  
        }  
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

        public AplusListData<User> GetUsers(AplusRequestData request)
        {
           
            List<User> _rows = new List<User>();
           int _count =_context.users.Count();
           if(_count > 0)
           _rows =  _context.users.Where(request.query).OrderBy(u => "u." + request.orderBy).Skip((request.pageSize - 1) * request.pageSize).Take(request.pageSize).ToList();
           
           return new AplusListData<User>{
               rows =_rows,
               page = 1,
               total = _count,
               pageSize = 20
           };
        }

        
    }
}