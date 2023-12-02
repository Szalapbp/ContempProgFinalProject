using Microsoft.AspNetCore.Mvc;
using ContempProgFinalProject.Models;
using ContempProgFinalProject.Data.TreeData;


namespace ContempProgFinalProject.Controllers
{
    public class TreeController : Controller
    {
        TreeContext ctx;
        public TreeController(TreeContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            ViewData["tree"] = ctx.Tree.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Tree m)
        {
            ctx.Tree.Add(m);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
