using Microsoft.AspNetCore.Mvc;

namespace CookieWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}