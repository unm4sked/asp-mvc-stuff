using System;
using System.Collections.Generic;
using System.Text;
using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.ApplicationCore.DTO;
using System.Threading.Tasks;

namespace B.HardwareTown.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductDTO Get(string name)
        {
            var product = _productRepository.Get(name);

            return new ProductDTO
            {
                Price = product.Price,
                Bought = product.Bought,
                Name = product.Name,
                Available = product.Available,
                Details = product.Details
            };
        }

		public ProductDTO GetByID(Guid id)
		{
			var product = _productRepository.GetByID(id);

			return new ProductDTO
			{
				Price = product.Price,
				Bought = product.Bought,
				Name = product.Name,
				Available = product.Available,
				Details = product.Details,
				
			};
		}

        public IEnumerable<ProductDTO> GetAllDTO()
        {
            List<ProductDTO> _productDTOs = new List<ProductDTO>();
            foreach(var p in _productRepository.GetAll())
            {
                _productDTOs.Add(new ProductDTO
                {
                    Price = p.Price,
                    Bought = p.Bought,
                    Name = p.Name,
                    Available = p.Available,
                    Details = p.Details,
					Id = p.Id
				}
                );
            }
            return _productDTOs;
        }

		public async Task<IEnumerable<ProductDTO>> GetAllAsync()
		{
			List<ProductDTO> _productDTOs = new List<ProductDTO>();
			foreach (var p in _productRepository.GetAll())
			{
				_productDTOs.Add(new ProductDTO
				{
					Price = p.Price,
					Bought = p.Bought,
					Name = p.Name,
					Available = p.Available,
					Details = p.Details,
					Id = p.Id
				}
				);
			}
			var productDTOs = await Task.Run(() => _productDTOs);

			return productDTOs;
		}
	}
}
