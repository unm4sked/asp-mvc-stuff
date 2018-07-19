using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
	{
		private readonly IProductService _productService;
		public ProductItemViewComponent(IProductService productService)
		{
			_productService = productService;
		}
		public async Task<IViewComponentResult> InvokeAsync(string search)
		{
			var item = await _productService.GetAllAsync();
			if (!String.IsNullOrEmpty(search))
			{
				item = item.Where(x => x.Name.Contains(search)).ToList();
				if (item.Count() == 0)
				{
					return View("_WrongSearch");
				}
			}
			return View(item);
		}
	}
}
