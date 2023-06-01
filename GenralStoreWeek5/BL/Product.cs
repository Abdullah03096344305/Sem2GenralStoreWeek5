using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenralStoreWeek5.BL
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Threshold { get; set; }

        // Constructor
        public Product(string name, string category, decimal price, int quantity, int threshold)
        {
            Name = name;
            Category = category;
            Price = price;
            Quantity = quantity;
            Threshold = threshold;
        }

        // Method to calculate sales tax based on category
        public decimal CalculateSalesTax()
        {
            decimal salesTax = 0;
            if (Category == "Grocery")
            {
                salesTax = Price * 0.1m;
            }
            else if (Category == "Fruit")
            {
                salesTax = Price * 0.05m;
            }
            else
            {
                salesTax = Price * 0.15m;
            }
            return salesTax;
        }
    }

    // Customer class
    class Customer
    {
        public string Name { get; set; }

        // Method to buy a product
        public void BuyProduct(Product product, int quantity)
        {
            if (product.Quantity >= quantity)
            {
                product.Quantity -= quantity;
                Console.WriteLine($"You bought {quantity} {product.Name}(s).");
            }
            else
            {
                Console.WriteLine("Insufficient stock.");
            }
        }
    }
}
