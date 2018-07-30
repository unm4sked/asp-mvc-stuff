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
			new Category("CPUs",1),
			new Category("Motherboards",2),
			new Category("Video Cards",3),
			new Category("Computer Cases",4),
			new Category("Memory",5),
			new Category("Power Supplies",6),
			new Category("Pre-built Computers",7),
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
