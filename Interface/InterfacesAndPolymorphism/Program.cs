using System;

// interfaces a just a contract
namespace InterfacesAndPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var encoder = new VideoEncoder();
            encoder.RegisterNotificationChannel(new MailNotificationChannel());
            encoder.RegisterNotificationChannel(new SmsNotificationChannel());
            encoder.Encode(new Video());
            Console.WriteLine("Hello World!");
        }
    }
}
