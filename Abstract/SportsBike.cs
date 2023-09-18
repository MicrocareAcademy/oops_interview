using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Abstract
{
    internal class SportsBike : Motorbike
    {

        // provide implementation of abstract method  
        public override void Brake()
        {
            Console.WriteLine("Sports Bike Brake");

        }

    }

}
