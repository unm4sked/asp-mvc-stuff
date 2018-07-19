using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B.HardwareTown.Infrastructure.Repositories
{
    public class InMemoryProductRepository : IProductRepository
    {

        
        private static ISet<Product> _product = new HashSet<Product>
        {
            new Product("1Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("2Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("3Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("4Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("5AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            new Product("6Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("7Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("8Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("9Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("10AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            new Product("11Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("12Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("13Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("14Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("15AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            new Product("16Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("17Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("18Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("19Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("20AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            new Product("21Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("22Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("23Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("23Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("25AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            new Product("26Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("27Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("28Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" } ),
            new Product("29Intel i3-3640X 3.00GHz 3MB BOX",449,new List<string>{ "Taktowanie: 3.0 GHz", "Liczba rdzeni: 3 rdzenie", "Cache: 36 MB", "Gniazdo procesora (socket) Socket 2066" } ),
            new Product("30AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" } ),
            
        };

        public void Add(Product product)
        {
            _product.Add(product);
        }

        public Product Get(string name)
            => _product.Single(x => x.Name == name.ToLowerInvariant());

		public Product GetByID(Guid id)
			=> _product.Single(x=>x.Id==id);

        public IEnumerable<Product> GetAll()
            => _product;

	}
}
