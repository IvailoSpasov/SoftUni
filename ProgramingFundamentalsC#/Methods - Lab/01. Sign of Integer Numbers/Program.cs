using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void printSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        static void Main(string[] args)
        {
            printSign(int.Parse(Console.ReadLine()));
        }
    }
}
