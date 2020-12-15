using System;

namespace UpcastingAndDowncasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = new Text(); // both these two classes point to the same place in memory

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);
        }
    }
}
