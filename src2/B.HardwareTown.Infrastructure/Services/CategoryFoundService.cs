using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Repositories;

namespace B.HardwareTown.Infrastructure.Services
{
    public class CategoryFoundService : ICategoryFoundService
    {
		private readonly IProductRepository _productRepository;
		public CategoryFoundService(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		public async Task <IList<CategoryFoundDTO>> GetFoundCategoriesAsync(string search)
		{
			var _productDTOs = _productRepository.GetAll();

			var categories =_productDTOs.Where(x => x.Name.Contains(search))
				.GroupBy(x => x.Category)
				.Select(x => new CategoryFoundDTO
				{
					Id = x.Key.Id,
					CategoryName = x.Key.CategoryName,
					Count = x.Count()
				}).ToList();
			var _categories = await Task.Run(() => categories);
			return _categories;
		}
	}
}
