using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double higth = double.Parse(Console.ReadLine());
            double V = ((lenght * width) * higth) / 3;
            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
