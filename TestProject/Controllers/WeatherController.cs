using ContempProgFinalProject.Data.WeatherForecastData;
using ContempProgFinalProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace ContempProgFinalProject.Controllers
{
    public class WeatherController : Controller
    {
        WeatherContext ctx;
        public WeatherController(WeatherContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            ViewData["weather"] = ctx.Weather.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(WeatherForecast w)
        {
            ctx.Weather.Add(w);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
