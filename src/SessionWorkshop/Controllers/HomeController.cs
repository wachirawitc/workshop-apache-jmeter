using Microsoft.AspNetCore.Mvc;

namespace SessionWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}