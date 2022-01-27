using aplus_back_seed.Models;
namespace aplus_back_seed.Interfaces
{
    public interface IAplusDataAccesses
    {
       IEnumerable<WeatherForecast> getWeather();
       AplusListData<User> GetUsers(AplusRequestData request);  
    }
}