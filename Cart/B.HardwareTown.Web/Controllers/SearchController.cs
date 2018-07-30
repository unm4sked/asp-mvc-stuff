using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.Controllers
{
    public class SearchController : Controller
    {
		private readonly IProductService _productService;
		private ICategoryRepository _categoryRepository;

		public SearchController(IProductService productService,ICategoryRepository category)
		{
			_productService = productService;
			_categoryRepository = category;
		}
		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index(string categoryname, string search, int productPage = 1, int PageSize = 20, string orderBy = "LP")
        {
            if (productPage <= 1)
                productPage = 1;
            if (PageSize <= 0)
                PageSize = 20;
            if (search == null)
                search = "";
			var items = await _productService.GetOneCategoriesProductsDTOAsync(categoryname);
			PagingInfo info = new PagingInfo()
			{
				ItemsPerPage = PageSize,
				CurrentPage = productPage,
				Search = search,
				CategoryName = categoryname,
                OrderBy = orderBy

            };

			ProductsPagingViewModel Vm = new ProductsPagingViewModel()
			{
				Products = items,
				PagingInfo = info
			};
			//ViewBag.Search = search;	
			return View(Vm);
        }
    }
}