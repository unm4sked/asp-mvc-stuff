using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;
using Microsoft.AspNetCore.Identity;

namespace B.HardwareTown.ApplicationCore.Services
{
    public class LikesService : ILikesService
    {
		private IProductRepository _productRepository;

		public LikesService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}

		public void AddLike(ProductDTO product)
		{
			var _product = _productRepository.GetByID(product.Id);
			product.LikesCount++;
			_product.LikesCount = product.LikesCount;
		}
		public void AddUserIdToProducts(ProductDTO product,string userId)
		{
			product.UsersWhoLiked.Add(new Like(userId));
		}

		public bool CheckUserId(ProductDTO product,string id)
		{
			var obj = product.UsersWhoLiked.Where(x => x.UserId == id);
			if (obj.Any())
			{
				return true;
			}
			return false;
		}

		public void UnLike(ProductDTO product)
		{
			var _product = _productRepository.GetByID(product.Id);
			product.LikesCount--;
			_product.LikesCount = product.LikesCount;
		}

		public void RemoveUserIdToProducts(ProductDTO product, string userId)
		{
			var Like = product.UsersWhoLiked.Where(x => x.UserId == userId).First();
			product.UsersWhoLiked.Remove(Like);
		}
	}
}
