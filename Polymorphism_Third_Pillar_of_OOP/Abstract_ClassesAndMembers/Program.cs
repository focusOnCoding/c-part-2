
namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // shape can not be init coz it is an abstract class 
            // var shape = new Shape();

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
