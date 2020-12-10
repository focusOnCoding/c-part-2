using System;

namespace Access_Modifiers
{
    public class Person
    {
        // hide info
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetDateTime()
        {
            return _birthdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1993, 06, 27));
            Console.WriteLine(person.GetDateTime());

            Console.WriteLine("Hello World!");
        }
    }
}
