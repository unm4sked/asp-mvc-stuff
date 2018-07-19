using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.ApplicationCore.DTO
{
    public class ProductDTO
    {
		public Guid Id { get; set; }
        public decimal Price { get; set; }
        public uint Bought { get; set; }
        public string Name { get; set; }
        public bool Available { get; set; }
        public List<string> Details { get; set; }
    }
}
