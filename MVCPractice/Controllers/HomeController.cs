using Microsoft.AspNetCore.Mvc;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Ok("Everything is okay)");
            // return Json(new { id = 1,City="Baku",Country="Azerbaijan",Population=10000000 });
            //return File("~/banner-1.png","image/png");
            TempData["Slogan"] ="Karabakh is Azerbaijan.";
            ViewData["Privacy"] = "Privacy is important for us..";
            ViewBag.PhoneNumber = "+994555555555";
			//return RedirectToAction(nameof(About));

			return View();
		}
		public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
