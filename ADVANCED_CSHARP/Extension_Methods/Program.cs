using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to a very long blog post blah blah blah.....";

            var shortendPost = post.Shorten(5);

            Console.WriteLine(shortendPost);

            // for the most part i will be using Extension Method then creating them see below
            IEnumerable<int> numberz = new List<int>() { 1, 3, 5, 34, 2, 18 };
            var max = numberz.Max();
        }
        
    }
    // #! i can not inherit from string !!!
    // public class CantInheritFromString : String { }
    // that where Extension Method coming to play
}
