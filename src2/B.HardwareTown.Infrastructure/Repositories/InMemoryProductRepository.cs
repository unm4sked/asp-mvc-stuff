using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
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

			new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
			new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
			new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
			new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
			new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
			new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("Intel i5-7640X 4.00GHz 6MB BOX",749,new List<string>{ "Taktowanie: 4.0 GHz", "Liczba rdzeni: 4 rdzenie", "Cache: 6 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i9-7900X 3.30GHz 13.75MB BOX",4131,new List<string>{ "Taktowanie: 3.3 GHz", "Liczba rdzeni: 10 rdzeni", "Cache: 13.75 MB", "Gniazdo procesora (socket) Socket 2066" },new Category("CPU")),
            new Product("Intel i7-8700K 3.70GHz 12MB",1619,new List<string>{ "Taktowanie: 3.6 GHz", "Taktowanie: 3.7 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 12 MB" },new Category("CPU")),
            new Product("AMD Ryzen 5 2600 ",835,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("CPU")),
            new Product("nVidia gt 1080 Ti",7654,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Video Card")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),
            new Product("HyperX nova",334,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory")),

            new Product("HyperX nova 2",355,new List<string>{ "Taktowanie: 3.4 GHz", "Liczba rdzeni: 6 rdzeni", "Cache: 19 MB", "Gniazdo procesora (socket) Socket AM4" },new Category("Memory"))
		};
		public void Add(Product product)
		{
			_product.Add(product);
		}

		public Product Get(string name)
			=> _product.Single(x => x.Name == name.ToLowerInvariant());

		public Product GetByID(Guid id)
			=> _product.Single(x => x.Id == id);

		public IEnumerable<Product> GetAll()
			=> _product;

	}
}
