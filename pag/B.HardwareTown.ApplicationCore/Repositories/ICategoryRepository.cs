using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using B.HardwareTown.ApplicationCore.Models;

namespace B.HardwareTown.ApplicationCore.Repositories
{
    public interface ICategoryRepository : IRepository
    {
	 IEnumerable<Category> GetAll();
	 Task<IEnumerable<Category>> GetCategoriesAsync();
	}
}
