using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.DTO;

namespace B.HardwareTown.Web.ViewModels
{
	public class CategoriesViewModel
	{
		public Guid id { get; set; } 
		public string productDTOs {get; set;}
		public int Count { get; set; }
    }
}
