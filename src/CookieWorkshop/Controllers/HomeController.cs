using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CookieWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public OkObjectResult Cookies()
		{
			var model = Request.Cookies.Select(x => new
			{
				x.Key,
				x.Value
			}).ToList();

			return Ok(new { model });
		}
	}
}