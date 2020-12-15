using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // incapsulation e.g
        public void Promote()
        {
            // e.g
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }

        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            // becuase of incapsulation i won be abut to do this
            var rating = customer.CalculateRating();
            Console.WriteLine("Hello World!");
        }
    }
}
