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
			Id = Guid.NewGuid();
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
