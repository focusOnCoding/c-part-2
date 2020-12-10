using System;

namespace Properties
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1993, 06, 27);
            Console.WriteLine(person.Age);
        }
    }
}
