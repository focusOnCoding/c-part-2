using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); // this takes object type so that alaws boxing
            list.Add("Siya");
            list.Add(DateTime.Today); // boxing

            // trying to unbox this array[1] will return an error
            var number = (int)list[1]; // string

            // better way
            var anotherList = new List<int>();
            // this is more type safe also no boxing will happen coz this is a list of int and not objects like the listArray above
            anotherList.Add(1 );
            Console.WriteLine("Hello World!");
        }
    }
}
