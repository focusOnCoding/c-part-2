using System;

namespace Classes
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} i am {1}", to , Name);
        }

        public static Person Parse (string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var p = Person.Parse("John");
            person.Name = "Siyabonga";
            person.Introduce("Dlamini");
            Console.WriteLine("Hello World!");
        }
    }
}
