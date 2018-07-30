using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.DTO;

namespace B.HardwareTown.Infrastructure.Services
{
    public interface ICategoryFoundService
    {
		Task<IList<CategoryFoundDTO>> GetFoundCategoriesAsync(string search);
		Task<IList<CategoryFoundDTO>> GetFoundOneCategoriesAsync(string search, IEnumerable<ProductDTO> products);
	}
}
