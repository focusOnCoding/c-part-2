using System;

namespace Properties
{
    
    class Program
    {
        static void Main(string[] args)
        {
            // becasue the setter is private i must now change the code
            var person = new Person(new DateTime(1993, 06, 27));
            Console.WriteLine(person.Age);
        }
    }
}
