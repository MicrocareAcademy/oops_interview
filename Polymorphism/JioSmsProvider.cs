using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Polymorphism
{
    internal class JioSmsProvider : ISmsProvider
    {
        public void SendSms(string phoneNumber, string message)
        {
            // logic to connect Jio sms provider and call send sms method

            Console.WriteLine("SMS was send through JIO SMS PROVIDER API");
        }
    }
}
