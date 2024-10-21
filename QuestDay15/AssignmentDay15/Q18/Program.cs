using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    internal class Program
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Price { get; set; } 
        }
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 989 },
                new Product { Id = 2, Name = "Smartphone", Price = 499 },
                new Product { Id = 3, Name = "Tablet", Price = 150 },
                new Product { Id = 4, Name = "Headphones", Price = 89 },
                new Product { Id = 5, Name = "Smartwatch", Price = 199 }
            };

            var filteredProducts = products
                     .Where(p => p.Price > 100)     
                     .OrderBy(p => p.Price);

            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
