using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            // because this takes any of the base objects as a param i can do this
            list.Add(1);
            list.Add("Siya");
            list.Add(new Text());
            // all the objects will be imiplectly converted to the base object class 

            // a better way to do the above using a generic class
            //[Upcasting]
            var anotherList = new List<int>(); // so every item in this list will be an (int)
            var shapes = new List<Shape>(); // list of shapes
        }
    }
}
