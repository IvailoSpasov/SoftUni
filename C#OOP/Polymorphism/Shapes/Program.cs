using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);
            Rectangle rec = new Rectangle(4, 3);

            Console.WriteLine(circle.Draw());
            Console.WriteLine(rec.Draw());
        }
    }
}
