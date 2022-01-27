using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figures = Console.ReadLine();

            if (figures == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * side:F3}");
            }
            else if (figures == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(sideB * sideA):F3}");
            }
            else if (figures == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI * (radius * radius):F3}");
            }
            else if (figures == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());
                Console.WriteLine($"{(side * hight) / 2:F3}");
            }
        }
    }
}
