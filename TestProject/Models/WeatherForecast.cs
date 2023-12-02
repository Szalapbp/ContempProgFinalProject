

namespace ContempProgFinalProject.Models
{
    public class WeatherForecast
    {
        public int Id { get; set; }
        public string Date { get; set; }

        public int TemperatureF{ get; set; }

        public string RoadConditions { get; set; }

        public string WeatherType { get; set; }
        public string GetText()
        {
            return $"{Id} \t {Date} \t {TemperatureF} \t {RoadConditions} \t {WeatherType}";
        }
    }
}