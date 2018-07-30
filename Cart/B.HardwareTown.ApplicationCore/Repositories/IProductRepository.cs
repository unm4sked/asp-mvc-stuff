using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.ApplicationCore.Repositories
{
    public interface IProductRepository : IRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(string name);
        Product GetByID(Guid id);
        void Add(Product product);
	}
}
