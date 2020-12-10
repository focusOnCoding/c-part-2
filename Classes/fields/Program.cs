using System;

namespace fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            // add two orders
            customer.Oreders.Add(new Orders());
            customer.Oreders.Add(new Orders());

            Console.WriteLine("Hello World!");
        }
    }
}
