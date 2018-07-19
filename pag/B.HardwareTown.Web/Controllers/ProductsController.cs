using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public int PageSize=20;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index(int productPage = 1, int PageSize =20)
        {
            var PageSize_ = (int)PageSize;
            var productPage_ = (int)productPage;
            return View(new ProductsListViewModel
            {
                Products = _productService.GetAllDTO()
                    .OrderBy(p => p.Name)
                    .Skip((productPage_ - 1) * PageSize_)
                    .Take(PageSize_),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage_,
                    ItemsPerPage = PageSize_,
                    TotalItems = _productService.GetAllDTO().Count()
                }
            });
        }
    }
}
