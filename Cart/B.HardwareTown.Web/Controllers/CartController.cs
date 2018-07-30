using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.Infrastructure.Extensions;
using B.HardwareTown.Infrastructure.Services;
using B.HardwareTown.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private Cart cart;
        public CartController(IProductService productService, Cart cartService)
        {
            cart = cartService;
            _productService = productService;
        }

        public RedirectToActionResult AddToCart(Guid productId, string returnUrl)
        {
            ProductDTO product = _productService.GetAllDTO()
                .FirstOrDefault(p => p.Id == productId);

            if(product !=null)
            {
                cart.AddItem(product, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(Guid productId, string returnUrl)
        {
            ProductDTO product = _productService.GetAllDTO()
                .FirstOrDefault(p => p.Id == productId);

            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public IActionResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}
