using ContempProgFinalProject.Data.FoodData;
using ContempProgFinalProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace ContempProgFinalProject.Controllers
{
    public class FoodController : Controller
    {
        FoodContext ctx;
        public FoodController(FoodContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            ViewData["food"] = ctx.Food.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Food w)
        {
            ctx.Food.Add(w);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
