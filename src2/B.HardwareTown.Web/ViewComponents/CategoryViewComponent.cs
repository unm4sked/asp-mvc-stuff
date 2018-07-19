using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
		private ICategoryRepository _categoryRepository;

		public CategoryViewComponent(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var items = await _categoryRepository.GetCategoriesAsync();
			return View(items);
		}
	}
}
