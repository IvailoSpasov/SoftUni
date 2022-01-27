using System;

namespace barcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int a = i % 10 / 1;
                int b = i % 100 / 10;
                int c = i % 1000 / 100;
                int d = i % 10000 / 1000;

                if (a % 2 != 0 && b % 2 != 0 && c % 2 != 0 && d % 2 != 0)
                {
                    Console.Write($"{d}{c}{b}{a} ");
                }
            }
        }
    }
}
