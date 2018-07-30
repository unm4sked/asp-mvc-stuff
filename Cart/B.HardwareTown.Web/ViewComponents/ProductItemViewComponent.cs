using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.DTO;
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
		public async Task<IViewComponentResult> InvokeAsync(string search,IEnumerable<ProductDTO> productsFromCategories,string categoryname, int productPage = 1, int PageSize = 20, string orderBy = "Like")
		{
            
            var item = await _productService.GetAllAsync();

            if ((!String.IsNullOrEmpty(categoryname) || !String.IsNullOrWhiteSpace(categoryname)) && item != null)
            {
                item = item.Where(x => x.Category.CategoryName == categoryname);
            }

            if (!String.IsNullOrEmpty(search))
			{
				item = item.Where(x => x.Name.Contains(search)).ToList();
				if (item.Count() == 0)
				{
					return View("_WrongSearch");
				}
			}

            if (productsFromCategories.Count() > 0)
            {
                item = productsFromCategories;
            }

            var PageSize_ = (int)PageSize;
            var productPage_ = (int)productPage;
            switch (orderBy)
            {
                case "LP":
                    return View(new ProductsPagingViewModel
                    {
                        Products = item
                            .OrderBy(p => p.Price)
                            .Skip((productPage_ - 1) * PageSize_)
                            .Take(PageSize_),
                        PagingInfo = new PagingInfo
                        {
                            Search = search,
                            CurrentPage = productPage_,
                            ItemsPerPage = PageSize_,
                            TotalItems = item.Count(),
                            CategoryName = categoryname,
                            OrderBy = orderBy
                        }
                    });

                case "HP":
                    return View(new ProductsPagingViewModel
                    {
                        Products = item
                           .OrderByDescending(p => p.Price)
                           .Skip((productPage_ - 1) * PageSize_)
                           .Take(PageSize_),
                        PagingInfo = new PagingInfo
                        {
                            Search = search,
                            CurrentPage = productPage_,
                            ItemsPerPage = PageSize_,
                            TotalItems = item.Count(),
                            CategoryName = categoryname,
                            OrderBy = orderBy
                        }
                    });
                default:
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
                            TotalItems = item.Count(),
                            CategoryName = categoryname,
                            OrderBy = orderBy
                        }
                    });
            }
        }
    }
}