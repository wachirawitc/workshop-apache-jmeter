using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using UploadWorkshop.ViewModels;

namespace UploadWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			var model = new UploadViewModel();
			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Upload(UploadViewModel model)
		{
			var rootPath = hostingEnvironment.WebRootPath;
			var filePath = Path.Combine(rootPath, model.File.FileName);

			using (var fileStream = new FileStream(filePath, FileMode.Create))
			{
				await model.File.CopyToAsync(fileStream);
			}

			return RedirectToAction(nameof(Index));
		}

		private readonly IHostingEnvironment hostingEnvironment;

		public HomeController(IHostingEnvironment hostingEnvironment)
		{
			this.hostingEnvironment = hostingEnvironment;
		}
	}
}