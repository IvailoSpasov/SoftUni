using System;

namespace _02._Numbers_N_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = number ; i >= 1 ; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
