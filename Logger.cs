using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS
{
    internal static class Logger
    {
        public static int LogCounter { get; set; }

        public static void LogError(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine(message);
        }
    }
}
