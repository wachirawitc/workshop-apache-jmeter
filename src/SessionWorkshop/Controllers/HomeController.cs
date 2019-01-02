using Microsoft.AspNetCore.Mvc;
using SessionWorkshop.Infrastructures.Interfaces;
using SessionWorkshop.ViewModels;

namespace SessionWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var xx = sessionContext.Username;
			var model = new LoginViewModel();
			return View(model);
		}

		[HttpPost]
		public IActionResult Login(LoginViewModel model)
		{
			if (ModelState.IsValid == false)
			{
				return View(nameof(Index), model);
			}

			sessionContext.Username = model.Username;

			return RedirectToAction(nameof(Index));
		}

		private readonly ISessionContext sessionContext;

		public HomeController(ISessionContext sessionContext)
		{
			this.sessionContext = sessionContext;
		}
	}
}