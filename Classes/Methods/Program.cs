using System;

namespace Methods
{
    
    class Program
    {
        static void Main(string[] args)
        {
        }
        static void usePoints()
        {
            // Global excaption handling
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                // problem when passing null !!
                point.Move(null); // theres no VELIDATION 
                Console.WriteLine("Point is at {0}, {1}", point.X, point.Y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured.");
            }

        }
    }
}
