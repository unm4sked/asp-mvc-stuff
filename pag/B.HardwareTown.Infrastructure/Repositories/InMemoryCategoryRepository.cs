using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;

namespace B.HardwareTown.Infrastructure.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
		private static ISet<Category> _product = new HashSet<Category>
		{
			new Category("CPU"),
			new Category("Motherboadrs"),
			new Category("Viedo Cards"),
			new Category("Computer Cases"),
			new Category("Memory"),
			new Category("Power Supplies"),
			new Category("Pre-built Computer"),
		};

		public IEnumerable<Category> GetAll()
		{
			 List<Category>_category = new List<Category>();
			foreach (var c in _product)
			{
				 _category.Add(new Category(c.CategoryName));
			}
			return _category;
		}

		public async Task<IEnumerable<Category>> GetCategoriesAsync()
		{
			List<Category> _category = new List<Category>();
			foreach (var c in _product)
			{
				_category.Add(new Category(c.CategoryName));
			}
			var category = await Task.Run(() => _category);

			return category;
		}
	}
}
