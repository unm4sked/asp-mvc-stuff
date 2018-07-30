using System;
using System.Collections.Generic;
using System.Text;
using B.HardwareTown.ApplicationCore.DTO;

namespace B.HardwareTown.ApplicationCore.Services
{
	public interface ILikesService
	{
		void AddLike(ProductDTO product);
		void UnLike(ProductDTO product);
		void AddUserIdToProducts(ProductDTO product, string userId);
		void RemoveUserIdToProducts(ProductDTO product, string userId);
		bool CheckUserId(ProductDTO product, string id);
	}
}
