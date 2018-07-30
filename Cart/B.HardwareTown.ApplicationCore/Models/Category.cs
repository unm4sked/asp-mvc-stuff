using System;
using System.Collections.Generic;
using System.Text;
using B.HardwareTown.ApplicationCore.DTO;
using B.HardwareTown.ApplicationCore.Repositories;

namespace B.HardwareTown.ApplicationCore.Models
{
    public class Category
    {
		public Guid Id { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }

		public Category(string name,int categoryid)
		{
			CategoryName = name;
			Id = Guid.NewGuid();
			CategoryId = categoryid;
		}

		public override bool Equals(object obj)
		{
			Category category = obj as Category;

			return (CategoryName == category.CategoryName);
		}

		public override int GetHashCode()
		{
			return CategoryName.GetHashCode();
		}
	}
}
