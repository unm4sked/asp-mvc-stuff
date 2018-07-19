using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.Controllers
{
    public class SearchController : Controller
    {
		private readonly IProductService _productService;
		public SearchController(IProductService productService)
		{
			_productService = productService;
		}
		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index(string search, int productPage = 1, int PageSize = 20)
        {
            if (search == null)
                search = "";
            PagingInfo info = new PagingInfo() { ItemsPerPage=PageSize, CurrentPage = productPage, Search = search};
            
            //ViewBag.Search = search;	
            return View(info);
        }
    }
}