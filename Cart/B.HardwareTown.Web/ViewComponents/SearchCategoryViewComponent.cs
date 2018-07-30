using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.ViewComponents
{
	public class SearchCategoryViewComponent : ViewComponent
	{
		private ICategoryFoundService _categoryFound;

		public SearchCategoryViewComponent(ICategoryFoundService categoryFound)
		{
			_categoryFound = categoryFound;
		}
		public async Task<IViewComponentResult> InvokeAsync(string search,IEnumerable<ProductDTO> products)
		{
			var _categoires = await _categoryFound.GetFoundCategoriesAsync(search);

			if (products != null)
			{
				_categoires = await _categoryFound.GetFoundOneCategoriesAsync(search, products);
				if (!String.IsNullOrEmpty(search))
				{
					_categoires = await _categoryFound.GetFoundCategoriesAsync(search);
				}
			}
			return View(_categoires);
		}
	}
}