using Microsoft.AspNetCore.Http;

namespace UploadWorkshop.ViewModels
{
	public class UploadViewModel
	{
		public IFormFile File { get; set; }
	}
}