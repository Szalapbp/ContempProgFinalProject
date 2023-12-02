using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.WeatherForecastData
{
    public interface IWeatherService
    {
        List<WeatherForecast> GetAllProducts();
        WeatherForecast GetWeatherById(int Id);

    }
}
