using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.Infrastructure.Services;
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
        public IActionResult Index(string search)
        {

            if (search == null)
                search = "";
            ViewBag.Search = search;	
            return View();
        }
    }
}