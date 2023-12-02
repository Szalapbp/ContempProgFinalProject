using ContempProgFinalProject.Models;
using Microsoft.EntityFrameworkCore;


namespace ContempProgFinalProject.Data.WeatherForecastData
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) :
            base(options)
        { }
        public DbSet<WeatherForecast> Weather { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasData(
            new WeatherForecast { Id = 1, Date = "10/23/2019", TemperatureF = 55, WeatherType = "Thunderstorm", RoadConditions = "Wet" },
            new WeatherForecast { Id = 2, Date = "3/11/2023", TemperatureF = 35, WeatherType = "Blizzard", RoadConditions = "Icy" }
            );

        }
    }
}
