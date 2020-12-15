using System;

namespace Access_Modifiers
{
    class Program
    {
        public class GoldCustomer : Customer
        {
            public void OfferVouchar()
            {
                // because of a change this is broken
                var rating = this.CalculateRating(excluderOrders: true);
            }
        }
        static void Main(string[] args)
        {
            var customer = new Customer();
            // becuase of incapsulation i won be abut to do this
            //var rating = customer.CalculateRating();  // now private
            Console.WriteLine("Hello World!");
        }
    }
}
