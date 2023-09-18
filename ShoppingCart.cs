using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcommerceOOPS.Inheritance;

namespace EcommerceOOPS
{
    internal class ShoppingCart
    {
        //private property
        private List<Product> items = new List<Product>();


        //method,its used to add item to cart
        public void AddToCart(Product product)
        {
            items.Add(product);
        }

        // method to display all items of cart
        public void DisplayCart()
        {
            Console.WriteLine("Shopping Cart Contents:");
            Console.WriteLine("-------------------");

            foreach (var product in items)
            {
                product.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
