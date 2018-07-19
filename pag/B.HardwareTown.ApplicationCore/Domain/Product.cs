using System;
using System.Collections.Generic;
using System.Text;

namespace B.HardwareTown.ApplicationCore.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public decimal Price { get; protected set; }
        public uint Bought { get; protected set; } = 0;
        public string Name { get; protected set; }
        public bool Available { get; protected set; }
        public List<string> Details { get; protected set; }
        public DateTime CreatedAt { get; protected set; } 
        

        private Product()
        { }
        public Product(string name, decimal price,List<string> detail)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            SetPrice(price);
            SetName(name);
            NotAvailable();
            Details = detail;

        }
        public void SetBought(uint bought)
        {
            if(bought<0)
                throw new Exception("Bought must be a positive nubmer.");
            Bought = bought;
            
        }
        public void SetPrice(decimal price)
        {
            if (price <= 0)
                throw new Exception("Price must be greater than 0.");
            Price = price;
        }
        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new Exception("Type your name correctly.");
            Name = name.ToLowerInvariant();
        }
        public void IsAvailable()
        {
            Available = true;
        }
        public void NotAvailable()
        {
            Available = false;
        }
        public void AddDetails(string details)
        {
            Details.Add(details);
        }
        public void SetDetails(List<string> details)
        {
            Details = details;
        }
        
    }
}
