using Microsoft.AspNetCore.Mvc;

namespace HttpRequesterWorkshop.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public OkObjectResult MethodOk()
		{
			return Ok(new
			{
				Message = "Response from 'MethodOk'"
			});
		}

		public OkObjectResult MethodOk(string id)
		{
			return Ok(new
			{
				Message = $"Response from 'MethodOk' and id is {id}"
			});
		}

		public BadRequestObjectResult MethodBadRequest()
		{
			return BadRequest(new
			{
				Message = "Response from 'MethodBadRequest'"
			});
		}
	}
}