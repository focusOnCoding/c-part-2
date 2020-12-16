using System;

namespace MethodOverriding
{
    // inherit from Shape
    public class Circle : Shape // incapsulating all it takes to draw a circle here so all of the circle life is here
    {
        // instade of being all over the place
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        // use the override key word to override this draw ==> virtual
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        // poor way of writing code 
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // the vrtual key word so i can change this method in a deraved class
        public virtual void Draw()
        {
            // this is where i add the drawing of a shape implemantation

        }
    }
}