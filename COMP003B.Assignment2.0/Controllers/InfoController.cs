using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment2._0.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult About()
        {
            return View();
        }
		public IActionResult Hobbies()
		{
			return View();
		}

	}
}
