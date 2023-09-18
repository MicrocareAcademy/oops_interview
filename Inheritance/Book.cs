using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Inheritance
{
    internal class Book : Product
    {
        public string Author { get; set; }

        public void DisplayName()
        {
            Console.WriteLine(
                $"Name of product: {Name} ");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine($"Author: {Author}");
        }

        public Book()
        {

        }

        public Book(string name, string description, decimal price, string author)
        : base(name, description, price)
        {
            Author = author;
        }

        
    }
}
