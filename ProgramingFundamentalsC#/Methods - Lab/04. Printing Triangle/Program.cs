using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void printingLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
        static void printingTriangles(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                printingLine(1,i);
            }

            for (int i = a - 1; i >= 0; i--)
            {
                printingLine(1,i);
            }
        }
        static void Main(string[] args)
        {
            printingTriangles(int.Parse(Console.ReadLine()));
        }
    }
}
