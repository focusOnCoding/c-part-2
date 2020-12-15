using System;

namespace ConstructorsAndIIheritance
{
    public class Car : Vehicle
    {
        // now there is an error to make this usable i must use : base
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
    }
}
