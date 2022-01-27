using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= range; i++)
            {
                int number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                bool trueOrFalse = false;
                trueOrFalse = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, trueOrFalse);
                sum = 0;
                i = number;
            }

        }
    }
}
