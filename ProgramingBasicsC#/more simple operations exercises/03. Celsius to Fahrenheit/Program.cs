using System;

namespace _03._Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"{c * 1.8 + 32:F2}");

        }
    }
}
