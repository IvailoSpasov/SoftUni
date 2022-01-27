using System;

namespace _08._Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculatetArea = Math.PI * (r * r);
            double calculatedParameter = 2 * Math.PI * r;

            Console.WriteLine($"{calculatetArea:F2}");
            Console.WriteLine($"{calculatedParameter:F2}");

        }
    }
}
