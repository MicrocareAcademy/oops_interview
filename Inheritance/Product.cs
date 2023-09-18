using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EcommerceOOPS.Inheritance
{
    internal class Product
    {
        public static string Vendor = "MICROCARE";

        public string? Name { get; set; }
        private int ProductId { get; set; }
        private string? Description { get; set; }
        private decimal Price { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Product ID: {ProductId}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Price: ${Price}");
        }







        // Constructors
        public Product()
        {
            // Initialize with default values
            ProductId = 0;
            Name = "Unnamed Product";
            Price = 0.0m;
        }




        public Product(string Name, string Description, decimal Price)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
        }















        public Product(int productId, string name,
                       string description, decimal price)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
        }

        // Method Overloading for SetPrice
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        // Overloaded SetPrice method to accept a discount percentage
        public void SetPrice(decimal basePrice, decimal discountPercentage)
        {
            decimal discountedPrice = basePrice * (1 - discountPercentage / 100);

            Price = discountedPrice;
        }

    }
}
