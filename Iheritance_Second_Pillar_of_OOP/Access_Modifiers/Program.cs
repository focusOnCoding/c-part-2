using System;
using Amazon;

namespace Access_Modifiers
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var customer = new Customer();
            // internal vs impemantation
            Amazon.RateCalculator calculator = new RateCalculator(); 
            // now this class wont to useble here corse its an intenal method
            Console.WriteLine("Hello World!");
        }
    }
}
