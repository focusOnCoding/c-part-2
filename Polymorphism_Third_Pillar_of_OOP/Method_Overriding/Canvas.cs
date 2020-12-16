using System;
using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        // use this way instade of a switch statement
        public void DrawShapes(List<Shape> shapes) // add list of all shapes so i can just iterrate over all of them
        {
            foreach (var shape in shapes)
            {
                // add support for tringle without having to change code in many places
                shape.Draw();
            }
        }
    }
}