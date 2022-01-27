using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int a = i % 10 / 1;
                int b = i % 100 / 10;
                int c = i % 1000 / 100;
                int d = i % 10000 / 1000;

                if (a == 0 || b == 0 || c == 0 || d == 0 )
                {
                    continue;
                }
                if (number % a == 0 && number % b == 0 && number % c == 0 && number % d == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
