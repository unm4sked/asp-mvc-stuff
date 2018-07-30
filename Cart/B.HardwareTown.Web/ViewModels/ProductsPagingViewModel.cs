using B.HardwareTown.ApplicationCore.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B.HardwareTown.Web.ViewModels
{
    public class ProductsPagingViewModel
    {
        public IEnumerable<ProductDTO> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
	public class PagingInfo
	{
		public int TotalItems { get; set; }
		public int ItemsPerPage { get; set; }
		public int CurrentPage { get; set; }
		public string Search { get; set; }
		public string CategoryName { get; set; }
        public string OrderBy { get; set; }

        public int TotalPages
            => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
