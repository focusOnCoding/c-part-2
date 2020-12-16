using System;

namespace AbstractClasses
{
    public class Rectangle : Shape
    {
        // now this shape to needs to have the Draw method because of the {abstract} 
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }
}