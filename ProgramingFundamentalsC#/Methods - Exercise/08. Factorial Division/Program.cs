using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double sum = FindFactorialOfNumber(number1) / FindFactorialOfNumber(number2);
            Console.WriteLine($"{sum:f2}");

        }

        private static double FindFactorialOfNumber(double number1)
        {
            double factorial = 1;
            while (number1 > 1)
            {
                factorial = factorial * number1;
                number1--;
            }

            return factorial;
        }
    }
}
