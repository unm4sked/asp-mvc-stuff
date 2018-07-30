using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Services;
using B.HardwareTown.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace B.HardwareTown.Web.Controllers
{
	public class DetailsController : Controller
	{
		private readonly IProductService _productService;
		private readonly SignInManager<Customer> _signInManager;
		private readonly UserManager<Customer> _userManager;
		private readonly ILikesService _likesServices;

		public DetailsController(IProductService productService,
			SignInManager<Customer> signInManager,
			UserManager<Customer> UserManager,
			ILikesService likesServices)
		{
			_productService = productService;
			_signInManager = signInManager;
			_userManager = UserManager;
			_likesServices = likesServices;
		}
		public IActionResult Index(Guid id)
		{
			return View(_productService.GetByID(id));
		}

		[HttpPost]
		public IActionResult Like(Guid id)
		{
			if (_signInManager.IsSignedIn(User))
			{
				var item = _productService.GetByID(id);
				var UserId = _userManager.GetUserId(User);

				if (!_likesServices.CheckUserId(item, UserId))
				{
					_likesServices.AddLike(item);
					_likesServices.AddUserIdToProducts(item, UserId);
					return RedirectToAction("Index", new { id });
				}
			}
			return RedirectToAction("Index", new { id });
		}

		[HttpPost]
		public IActionResult UnLike(Guid id)
		{
			if (_signInManager.IsSignedIn(User))
			{
				var item = _productService.GetByID(id);
				var UserId = _userManager.GetUserId(User);

				if (_likesServices.CheckUserId(item, UserId))
				{
					_likesServices.UnLike(item);
					_likesServices.RemoveUserIdToProducts(item, UserId);
					return RedirectToAction("Index", new { id });
				}
			}
			return RedirectToAction("Index", new { id });
		}
	}
}