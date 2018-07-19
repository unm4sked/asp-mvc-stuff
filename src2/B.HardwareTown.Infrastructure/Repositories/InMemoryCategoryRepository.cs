using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;

namespace B.HardwareTown.Infrastructure.Repositories
{
    public class InMemoryCategoryRepository : ICategoryRepository
    {
		private static ISet<Category> _category = new HashSet<Category>
		{
			new Category("CPU"),
			new Category("Motherboadrs"),
			new Category("Viedo Cards"),
			new Category("Computer Cases"),
			new Category("Memory"),
			new Category("Power Supplies"),
			new Category("Pre-built Computer"),
		};

		public Category GetByName(string name)
		   => _category.Single(x => x.CategoryName == name.ToLowerInvariant());

		public IEnumerable<Category> GetAll()
		{
			return _category;
		}

		public async Task<IEnumerable<Category>> GetCategoriesAsync()
		{
			var category = await Task.Run(() => _category);

			return category;
		}
	}
}
