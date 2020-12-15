using System;
using System.Collections.Generic;
using System.Text;

namespace Association_Between_Classes
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied to clipbord.");
        }

        public void Duplicate()
        {
            Console.WriteLine("object was Duplicated.");
        }
    }
}
