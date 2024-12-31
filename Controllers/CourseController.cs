using Microsoft.AspNetCore.Mvc;
using RoyalArtSchool.Models;

namespace RoyalArtSchool.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //get için çalışan methodur. [HttpGet] yazmasa da defaultu gettit
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            return View();
        }
    }
}
