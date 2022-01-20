namespace aplus_back_seed.Interfaces
{
    public interface IAplusDataAccesses
    {
       IEnumerable<WeatherForecast> getWeather();
    }
}