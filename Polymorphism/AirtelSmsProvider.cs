using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOOPS.Polymorphism
{
    internal class AirtelSmsProvider : ISmsProvider
    {
        public void SendSms(string phoneNumber, string message)
        {
            // logic to connect Airtel Sms api to call send sms

            Console.WriteLine("SMS was sent through Airtel SMS API");
        }
    }
}
