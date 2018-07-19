using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.ApplicationCore.Models
{
    public class Category
    {
		public Guid Id { get; set; }
		public string CategoryName { get; set; }

		public Category(string name)
		{
			CategoryName = name;
		}
	}
}
