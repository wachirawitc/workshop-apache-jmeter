using Microsoft.AspNetCore.Mvc;
using SummitFormsWorkshop.Extensions;
using SummitFormsWorkshop.ViewModels;
using System.Collections.Generic;

namespace SummitFormsWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var prefixes = new List<SelectItemViewModel>
			{
				new SelectItemViewModel {Text = "Select All", Value = null},
				new SelectItemViewModel {Text = "Major/Master Sergeant", Value = "MSgt"},
				new SelectItemViewModel {Text = "Mister", Value = "Mr"},
				new SelectItemViewModel {Text = "Married Woman", Value = "Mrs"},
				new SelectItemViewModel {Text = "Single or Married Woman", Value = "Ms"}
			};

			var model = new InformationViewModel();
			model.Prefixes = prefixes.ToSelectList();
			return View(model);
		}

		[HttpPost]
		public IActionResult Information(InformationViewModel model)
		{
			return Ok(model);
		}
	}
}