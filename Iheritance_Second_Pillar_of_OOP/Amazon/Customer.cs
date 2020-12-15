using System;

namespace Amazon
{
    /*public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }*/
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); // bad way of inishalizing an object
            var rating = calculator.Calculate(this); // pass in this (Customer) as param

             
            Console.WriteLine();
        } 
    }
}
