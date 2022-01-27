using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine($"{number} X {n} = {number*n}");
            }
            else
            {
                for (int i = n; i < 11; i++)
                {
                    int sum = i * number;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
            
        }
    }
}
