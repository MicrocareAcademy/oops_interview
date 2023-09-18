


using EcommerceOOPS.Polymorphism;

string phoneNo = "+91 990900909";
string msg = "Your appointment wa booked on 12/12/2023";

//ISmsProvider smsProvider = new AirtelSmsProvider();

ISmsProvider smsProvider = new JioSmsProvider();
smsProvider.SendSms(phoneNo, msg);









