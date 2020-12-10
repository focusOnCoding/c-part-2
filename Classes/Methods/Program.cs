using System;

namespace Methods
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));

            Console.WriteLine("Point is at {0}, {1}", point.X, point.Y  );

            // problem when passing null !!
            point.Move(null); // theres no VELIDATION 

            // Global excaption handling
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
