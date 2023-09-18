using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Abstract
{
    internal class MountainBike : Motorbike
    {

        // provide implementation of abstract method
        public override void Brake()
        {
            Console.WriteLine("Mountain Bike Brake");

        }

    }
}
