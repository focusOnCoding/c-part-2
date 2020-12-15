using System;

namespace Association_Between_Classes
{

    
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            // now i have inherited this from the parent class Inheritace1 in this case
            text.Width = 100;
            text.Copy();
            Console.WriteLine("Hello World!");
            Console.WriteLine("hello {0} {1}");
        }
    }
}
