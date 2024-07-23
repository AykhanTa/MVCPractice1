using Microsoft.AspNetCore.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; } = new()
        {
            new(){Id=1,Name="Azerbaijan",Population=100000},
			new(){Id=2,Name="Turkey",Population=222222222},

        };
		public List<City> Cities { get; set; } = new()
		{
			new(){Id=1,Name="Baku",CountryId=1 },
			new(){Id=1,Name="Nakhcivan",CountryId=1 },
			new(){Id=1,Name="Antalya",CountryId=2 },
			new(){Id=2,Name="Izmir",CountryId=2},

		};
		public IActionResult Index()
        {
            //return Ok("Everything is okay)");
            // return Json(new { id = 1,City="Baku",Country="Azerbaijan",Population=10000000 });
            //return File("~/banner-1.png","image/png");
            //TempData["Slogan"] ="Karabakh is Azerbaijan.";
            //ViewData["Privacy"] = "Privacy is important for us..";
            //ViewBag.PhoneNumber = "+994555555555";
			//return RedirectToAction(nameof(About));

			return View(Countries);
		}
		public IActionResult About(int? id)
        {
            if (id == null) return BadRequest();
            var countryCities= Cities.FindAll(x => x.CountryId == id);
            return View(countryCities);
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
