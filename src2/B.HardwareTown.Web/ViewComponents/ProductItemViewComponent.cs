using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.ViewComponents
{
    public class ProductItemViewComponent : ViewComponent
	{
		private readonly IProductService _productService;
        public int PageSize = 20;

        public ProductItemViewComponent(IProductService productService)
		{
			_productService = productService;
		}
		public async Task<IViewComponentResult> InvokeAsync(string search, int productPage = 1, int PageSize = 20)
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
            var PageSize_ = (int)PageSize;
            var productPage_ = (int)productPage;
            return View(new ProductsPagingViewModel
            {
                Products = item
                    .OrderBy(p => p.Name)
                    .Skip((productPage_ - 1) * PageSize_)
                    .Take(PageSize_),
                PagingInfo = new PagingInfo
                {
                    Search = search,
                    CurrentPage = productPage_,
                    ItemsPerPage = PageSize_,
                    TotalItems = item.Count()
                }
            });
            
		}
	}
}
