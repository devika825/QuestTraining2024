using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventorymanagement
{
    internal class Program
    {
        
        static Dictionary<string, Dictionary<string, object>> inventory = new Dictionary<string, Dictionary<string, object>>();

        static void AddProduct()
        {
            Console.WriteLine("Enter Product ID:");
            string productId = Console.ReadLine();

            if (inventory.ContainsKey(productId))
            {
                Console.WriteLine("Product ID already exists. Please use a unique Product ID.");
                return;
            }

            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Product Stock:");
            int stock = int.Parse(Console.ReadLine());


            var productDetails = new Dictionary<string, object>
            {
                { "Name", name },
                { "Price", price },
                { "Stock", stock }
            };

            inventory.Add(productId, productDetails);
            Console.WriteLine("Product added successfully.");
        }

        static void UpdateStock()
        {
            Console.WriteLine("Enter Product ID to update stock:");
            string productId = Console.ReadLine();

            if (!inventory.ContainsKey(productId))
            {
                Console.WriteLine("Product not found.");
                return;
            }

            Console.WriteLine("Enter the new stock quantity:");
            int newStock = int.Parse(Console.ReadLine());

            
            inventory[productId]["Stock"] = newStock;
            Console.WriteLine("Stock updated successfully.");
        }

        static void GetProductDetails()
        {
            Console.WriteLine("Enter Product ID to retrieve details:");
            string productId = Console.ReadLine();

            if (inventory.TryGetValue(productId, out var productDetails))
            {
                Console.WriteLine($"Product ID: {productId}");
                Console.WriteLine($"Name: {productDetails["Name"]}");
                Console.WriteLine($"Price: {productDetails["Price"]}");
                Console.WriteLine($"Stock: {productDetails["Stock"]}");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
        }

        // Function to return a list of products that have stock below a certain threshold
        static void GetLowStockProducts()
        {
            Console.WriteLine("Enter the stock threshold:");
            int threshold = int.Parse(Console.ReadLine());

            Console.WriteLine("Low stock products:");
            foreach (var product in inventory)
            {
                if ((int)product.Value["Stock"] < threshold)
                {
                    Console.WriteLine($"Product ID: {product.Key}, Name: {product.Value["Name"]}, Stock: {product.Value["Stock"]}");
                }
            }
        }



        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Stock");
                Console.WriteLine("3. Get Product Details");
                Console.WriteLine("4. Get Low Stock Products");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

              
                switch (option)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2":
                        UpdateStock();
                        break;
                    case "3":
                        GetProductDetails();
                        break;
                    case "4":
                        GetLowStockProducts();
                        break;
                    case "5":
                        return;  // Exit the program
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;


                }
            }

        }
    }
}
