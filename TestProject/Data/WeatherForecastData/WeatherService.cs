using ContempProgFinalProject.Data.WeatherForecastData;
using ContempProgFinalProject.Models;

namespace ContempProgFinalProject.Data.WeatherForecastData
{
    public class WeatherService : IWeatherService
    {
        WeatherContext ctx;
        public WeatherService(WeatherContext context)
        {
            ctx = context;
        }
        List<WeatherForecast> IWeatherService.GetAllProducts()
        {
            return ctx.Weather.ToList();
        }

        WeatherForecast IWeatherService.GetWeatherById(int Id)
        {
            return ctx.Weather.FirstOrDefault(x => x.Id == Id);
        }
    }
}
