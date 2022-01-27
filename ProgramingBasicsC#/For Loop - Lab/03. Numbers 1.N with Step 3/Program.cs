using System;

namespace _03._Numbers_1.N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int number = 1; number <= endNumber; number += 3)
            {
                Console.WriteLine(number);
            }
        }
    }
}
