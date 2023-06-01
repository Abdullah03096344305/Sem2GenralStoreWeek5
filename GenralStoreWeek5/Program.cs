using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenralStoreWeek5.BL;
using System.Threading.Tasks;

namespace GenralStoreWeek5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("Apple", "Fruit", 1.99m, 50, 10));
            products.Add(new Product("Bread", "Grocery", 2.49m, 100, 20));
            products.Add(new Product("Shirt", "Clothing", 19.99m, 20, 5));
            Customer customer = new Customer();
            customer.Name = "Ali";
            Console.WriteLine("Admin Menu");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View All Products");
            Console.WriteLine("3. Find Product with Highest Unit Price");
            Console.WriteLine("4. View Sales Tax of All Products");
            Console.WriteLine("5. Products to be Ordered (less than threshold)");
            Console.WriteLine("6. Exit");

            // Get user input
            Console.WriteLine("Enter your choice:");
            int adminChoice = Convert.ToInt32(Console.ReadLine());

            if (adminChoice == 1)
            {
                // Add Product
                Console.WriteLine("Enter product details:");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Category: ");
                string category = Console.ReadLine();
                Console.WriteLine("Price: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Threshold: ");
                int threshold = Convert.ToInt32(Console.ReadLine());

                // Create a new product and add it to the list
                Product newProduct = new Product(name, category, price, quantity, threshold);
                products.Add(newProduct);
                Console.WriteLine("Product added successfully.");
            }
            else if (adminChoice == 2)
            {
                Console.WriteLine("All Products:");
                foreach (Product product in products)
                {
                    Console.WriteLine($"Name: {product.Name}, Category: {product.Category}, Price: {product.Price}, Quantity: {product.Quantity}");
                }
            }
            else if (adminChoice == 3)
            {
                // Find Product with Highest Unit Price
                Product highestPriceProduct = products[0];
                foreach (Product product in products)
                {
                    if (product.Price > highestPriceProduct.Price)
                    {
                        highestPriceProduct = product;
                    }
                }
                Console.WriteLine($"Product with the highest unit price: {highestPriceProduct.Name}");
            }
            else if (adminChoice == 4)
            {
                // View Sales Tax of All Products
                Console.WriteLine("Sales Tax of All Products:");
                foreach (Product product in products)
                {
                    decimal salesTax = product.CalculateSalesTax();
                    Console.WriteLine($"Product: {product.Name}, Sales Tax: {salesTax}");
                }
            }
            else if (adminChoice == 5)
            {
                // Products to be Ordered (less than threshold)
                Console.WriteLine("Products to be Ordered:");
                foreach (Product product in products)
                {
                    if (product.Quantity < product.Threshold)
                    {
                        Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
                    }
                }
            }
            else if (adminChoice == 6)
            {
                // Exit
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        

        }
    }
}
