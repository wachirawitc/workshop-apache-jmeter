using Microsoft.AspNetCore.Mvc.Rendering;
using SummitFormsWorkshop.ViewModels;
using System.Collections.Generic;

namespace SummitFormsWorkshop.Extensions
{
	public static class SelectListExtension
	{
		public static SelectList ToSelectList(this IEnumerable<SelectItemViewModel> sources)
		{
			if (sources == null)
			{
				sources = new List<SelectItemViewModel>();
			}

			return new SelectList(sources, nameof(SelectItemViewModel.Value), nameof(SelectItemViewModel.Text));
		}
	}
}