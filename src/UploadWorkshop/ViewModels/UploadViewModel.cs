using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace UploadWorkshop.ViewModels
{
	public class UploadViewModel
	{
		public List<string> ExitsFiles { get; set; } = new List<string>();

		public IFormFile File { get; set; }
	}
}