using Microsoft.AspNetCore.Mvc.Rendering;

namespace SummitFormsWorkshop.ViewModels
{
	public class InformationViewModel
	{
		public string Prefix { get; set; }

		public SelectList Prefixes { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }
	}
}