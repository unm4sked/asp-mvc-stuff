using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace B.HardwareTown.Infrastructure.Services
{
    public interface IProductService
    {
		ProductDTO Get(string name);
		ProductDTO GetByID(Guid id);
		IEnumerable<ProductDTO> GetAllDTO();
		Task<IEnumerable<ProductDTO>> GetAllAsync();
		Task<IEnumerable<ProductDTO>> GetOneCategoriesProductsDTOAsync(string categoryName);
	}
}
