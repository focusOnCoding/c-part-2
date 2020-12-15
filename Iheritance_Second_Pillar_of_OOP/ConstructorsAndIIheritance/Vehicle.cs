using System;

namespace ConstructorsAndIIheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        /*public Vehicle()
        {   
            Console.WriteLine("Vehicle is being init initalizd");
        }*/

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized {0}", registrationNumber);
        }
    }
}
