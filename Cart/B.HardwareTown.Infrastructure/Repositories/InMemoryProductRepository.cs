using B.HardwareTown.ApplicationCore.Domain;
using B.HardwareTown.ApplicationCore.Models;
using B.HardwareTown.ApplicationCore.Repositories;
using B.HardwareTown.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace B.HardwareTown.Infrastructure.Repositories
{
	public class InMemoryProductRepository : IProductRepository
	{
		private ICategoryRepository _categoryRepository;
		public InMemoryProductRepository(ICategoryRepository categoryRepository)
		{
			_categoryRepository = categoryRepository;
		}
		private static ISet<Product> _product = new HashSet<Product>
		{
			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"ASRock H99 XD",
				399,
				new List<string>
				{
					"Rozmiar płyty: ATX",
					"Chipset: Bambo H99",
					"Porty USB: 20",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Asus Z100 LOL",
				1000,
				new List<string>
				{
					"Rozmiar płyty: miniATX",
					"Chipset: Z100 ",
					"Porty USB: 10000",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova 2",
				355,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Alea M50",
				100,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX",
					"Typ obudowy: Cube",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X2"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Brutus 100",
				120,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX, ATX",
					"Typ obudowy: Midi Tower",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X4"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Vero m1",
				99,
				new List<string>
				{
					"Certyfikat sprawności: 80 Plus Platinum",
					"Moc [W]: 600",
					"Modularne okablowanie: Tak"
				},
				new Category("Power Supplies",6),
				"Power Supplies",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"BAMBO EXTREME SUPER E-SPORT GAMER EDITION",
				120,
				new List<string>
				{
					"Chipset graficzny: Bambeon VEGE 13",
					"Model procesora: EBE Rożen 5000G",
					"Model płyty: EMSI 1000000 PRO",
					"Seria: Gender",
					"Wielkość pamięcia RAM: 128 GB"
				},
				new Category("Pre-built Computers",7),
				"Pre-built Computers",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"ASRock H99 XD",
				399,
				new List<string>
				{
					"Rozmiar płyty: ATX",
					"Chipset: Bambo H99",
					"Porty USB: 20",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Asus Z100 LOL",
				1000,
				new List<string>
				{
					"Rozmiar płyty: miniATX",
					"Chipset: Z100 ",
					"Porty USB: 10000",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova 2",
				355,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Alea M50",
				100,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX",
					"Typ obudowy: Cube",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X2"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Brutus 100",
				120,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX, ATX",
					"Typ obudowy: Midi Tower",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X4"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Vero m1",
				99,
				new List<string>
				{
					"Certyfikat sprawności: 80 Plus Platinum",
					"Moc [W]: 600",
					"Modularne okablowanie: Tak"
				},
				new Category("Power Supplies",6),
				"Power Supplies",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"BAMBO EXTREME SUPER E-SPORT GAMER EDITION",
				120,
				new List<string>
				{
					"Chipset graficzny: Bambeon VEGE 13",
					"Model procesora: EBE Rożen 5000G",
					"Model płyty: EMSI 1000000 PRO",
					"Seria: Gender",
					"Wielkość pamięcia RAM: 128 GB"
				},
				new Category("Pre-built Computers",7),
				"Pre-built Computers",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"ASRock H99 XD",
				399,
				new List<string>
				{
					"Rozmiar płyty: ATX",
					"Chipset: Bambo H99",
					"Porty USB: 20",
					"Gniazdo procesora (socket) Socket 2066"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Asus Z100 LOL",
				1000,
				new List<string>
				{
					"Rozmiar płyty: miniATX",
					"Chipset: Z100 ",
					"Porty USB: 10000",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Motherboards",2),
				"Motherboards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i9-7900X 3.30GHz 13.75MB BOX",
				4131,
				new List<string>
				{
					"Taktowanie: 3.3 GHz",
					"Liczba rdzeni: 10 rdzeni",
					"Cache: 13.75 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i7-8700K 3.70GHz 12MB",
				1619,
				new List<string>
				{
					"Taktowanie: 3.6 GHz",
					"Taktowanie: 3.7 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 12 MB" },
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"AMD Ryzen 5 2600 ",
				835,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"nVidia gt 1080 Ti",
				7654,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Video Cards",3),
				"Video Cards",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova",
				334,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"Intel i5-7640X 4.00GHz 6MB BOX",
				749,
				new List<string>
				{
					"Taktowanie: 4.0 GHz",
					"Liczba rdzeni: 4 rdzenie",
					"Cache: 6 MB",
					"Gniazdo procesora (socket) Socket 2066"
				},new Category("CPUs",1),
				"CPUs",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"HyperX nova 2",
				355,
				new List<string>
				{
					"Taktowanie: 3.4 GHz",
					"Liczba rdzeni: 6 rdzeni",
					"Cache: 19 MB",
					"Gniazdo procesora (socket) Socket AM4"
				},
				new Category("Memory",5),
				"Memory",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Alea M50",
				100,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX",
					"Typ obudowy: Cube",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X2"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Brutus 100",
				120,
				new List<string>
				{
					"Kompatybilniść: miniITX, microATX, ATX",
					"Typ obudowy: Midi Tower",
					"Zasilacz: NJEEEE",
					"Złącza USB: USB 3.0 X4"
				},
				new Category("Computer Cases",4),
				"Computer Cases",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"SilentiumPC Vero m1",
				99,
				new List<string>
				{
					"Certyfikat sprawności: 80 Plus Platinum",
					"Moc [W]: 600",
					"Modularne okablowanie: Tak"
				},
				new Category("Power Supplies",6),
				"Power Supplies",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				),

			new Product(
				"BAMBO EXTREME SUPER E-SPORT GAMER EDITION",
				120,
				new List<string>
				{
					"Chipset graficzny: Bambeon VEGE 13",
					"Model procesora: EBE Rożen 5000G",
					"Model płyty: EMSI 1000000 PRO",
					"Seria: Gender",
					"Wielkość pamięcia RAM: 128 GB"
				},
				new Category("Pre-built Computers",7),
				"Pre-built Computers",
				new Images(File.ReadAllBytes("wwwroot/images/cpu.png")),
				File.ReadAllText("wwwroot/descriptionHTML/description.txt").ToString()
				)
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
