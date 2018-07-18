using System.Collections.Generic;
using System.Linq;

namespace SportStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name="Pilka nozna", Price = 25},
            new Product { Name="Buty", Price = 215},
            new Product { Name="Koszulka ", Price = 15},
            new Product { Name="Telfon ", Price = 1133},
            new Product { Name="Kozaki ", Price = 135},
            new Product { Name="Woda ", Price = 1435},
            new Product { Name="Samochod ", Price = 153},
            new Product { Name="Zegarek ", Price = 152},
            new Product { Name="Stol ", Price = 151},
            new Product { Name="Pilka nozna", Price = 25},
            new Product { Name="Buty", Price = 215},
            new Product { Name="Koszulka ", Price = 15},
            new Product { Name="Telfon ", Price = 1133},
            new Product { Name="Kozaki ", Price = 135},
            new Product { Name="Woda ", Price = 1435},
            new Product { Name="Samochod ", Price = 153},
            new Product { Name="Zegarek ", Price = 152},
            new Product { Name="Stol ", Price = 151},
             new Product { Name="Kozaki ", Price = 135},
            new Product { Name="Woda ", Price = 1435},
            new Product { Name="Samochod ", Price = 153},
            new Product { Name="Zegarek ", Price = 152},
            new Product { Name="Stol ", Price = 151},
            new Product { Name="Spodnie ", Price = 100}


        }.AsQueryable<Product>();
    }
}