using Microsoft.AspNetCore.Mvc;
using ContempProgFinalProject.Models;
using ContempProgFinalProject.Data.TeamMemberData;


namespace ContempProgFinalProject.Controllers
{
    public class TeamMembersController : Controller
    {
        TeamMemberContext ctx;
        public TeamMembersController(TeamMemberContext context)
        {
            ctx = context;
        }
        public IActionResult Index()
        {
            ViewData["members"] = ctx.Members.ToList();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(TeamMembers m) 
        {
            ctx.Members.Add(m);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
