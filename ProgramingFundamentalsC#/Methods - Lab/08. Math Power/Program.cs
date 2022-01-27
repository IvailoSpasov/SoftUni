using System;

namespace _08._Math_Power
{
    class Program
    {
        static double mathPower(double n, double power)
        {
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= n;
            }
            return result;
        }
        static void Main(string[] args)
        {
           double number = double.Parse(Console.ReadLine());
           double power = double.Parse(Console.ReadLine());
            
            Console.WriteLine(mathPower(number,power));
        }
    }
}
