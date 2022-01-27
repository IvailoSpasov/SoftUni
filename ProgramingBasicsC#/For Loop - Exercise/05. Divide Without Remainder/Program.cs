using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1++;
                }
                if (number % 3 == 0)
                {
                    p2++;
                }
                if (number % 4 == 0)
                {
                    p3++;
                }
            }
            double percent1 = (p1 / n) * 100;
            double percent2 = (p2 / n) * 100;
            double percent3 = (p3 / n) * 100;

            Console.WriteLine($"{percent1:F2}%");
            Console.WriteLine($"{percent2:F2}%");
            Console.WriteLine($"{percent3:F2}%");
        }
    }
}
