using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<ProductDTO> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
