using System;

namespace _02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                
                for (int n = 1; n <= 10; n++)
                {
                    int sum = i * n;
                    Console.WriteLine($"{i} * {n} = {sum}");
                }
                
            }
        }
    }
}
