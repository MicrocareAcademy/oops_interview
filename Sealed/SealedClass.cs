using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Sealed
{
    internal sealed class SealedClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }

    //public class InheritedClass : SealedClass { }
}
