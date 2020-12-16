using System.Collections.Generic;

namespace MethodOverriding
{
    // Polymorphism means many forms in greck
    class Program
    {
        static void Main(string[] args)
        {
            // list a just better at 80% of what i will be doing with my code
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
