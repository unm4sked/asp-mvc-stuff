using System;
using System.Collections.Generic;
using System.Linq;

namespace episodes.Models
{
    public class LinqTest
    {
        public void Test()
        {
            var items = GetItems();
            var tools = items.Where(x => x.Category == "Tools");
            // to samo
            // var toolsQuery = from tool in tools 
            //                  where tool.Category =="Tools" 
            //                  select tool;
            var axe1 = tools.FirstOrDefault(x => x.Name == "Helmet");
            var axe2 = tools.SingleOrDefault(x => x.Name == "Helmet");

            var numbers = Enumerable.Range(1,10);
            var max = numbers.Max();
            var sum = numbers.Sum();

            var totalPriceTools = tools.Sum(x => x.Price);
            var food = items.Where(x => x.Category == "Food");
            var FoodAndTools = tools.Union(food);

            var query = items.Where(x => x.CreatedAt >= DateTime.UtcNow.AddDays(-10))
                .Where(x => x.Price >300)
                .Skip(1)
                .Take(1)
                .OrderBy(x => x.Price)
                .Select(x => new {x.Name, x.Price});

            var groupedItems = items.GroupBy(x => x.Category);
            var dictionary = query.ToDictionary(x => x.Name, x => x.Price);
        }

        public IEnumerable<Item> GetItems()
        {
            yield return new Item("Axe","Tools",250,DateTime.UtcNow.AddDays(-15));
            yield return new Item("Dog","Animal",250,DateTime.UtcNow.AddDays(-15));
            yield return new Item("Cat","Animal",250,DateTime.UtcNow.AddDays(-15));
            yield return new Item("Car","Vehicle",20000,DateTime.UtcNow.AddDays(-15));
            yield return new Item("Bike","Vehicle",20,DateTime.UtcNow.AddDays(-15));

        }
    }

    public class Item
    {
        public Guid Id { get; protected set;} 
        public string Name { get; protected set;}
        public string Category { get; protected set;}
        public decimal Price { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        public Item(string name, string category, decimal price, DateTime createdAt)
        {
            Id = Guid.NewGuid();
            Name = name;
            Category = category;
            Price = price;
            CreatedAt = createdAt;
        }
    }
}