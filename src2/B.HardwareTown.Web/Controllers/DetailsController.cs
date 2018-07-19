using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.Controllers
{
    public class DetailsController : Controller
    {
		private readonly IProductService _productService;
		public DetailsController(IProductService productService)
		{
			_productService = productService;
		}
		public IActionResult Index(Guid id)
        {
            return View(_productService.GetByID(id));
        }
    }
}