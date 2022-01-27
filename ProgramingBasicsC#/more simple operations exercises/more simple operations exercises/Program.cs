using System;

namespace more_simple_operations_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine($"{a * h / 2:F2}");
        }
    }
}
