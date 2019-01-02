using Microsoft.AspNetCore.Mvc;

namespace UploadWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}