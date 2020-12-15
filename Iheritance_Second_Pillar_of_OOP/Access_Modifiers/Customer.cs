using System;

namespace Access_Modifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // incapsulation e.g
        /*public void Promote()
        {
            // e.g
            var rating = CalculateRating(excluderOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to level 1");
            else
                Console.WriteLine("Promoted to level 2");
        }*/

        // so the better way is to change this yto a private mathod
        // change to protected and why its bad
        //protected int CalculateRating(bool excluderOrders)
        //{
        //    return 0;
        //}
    }
}
