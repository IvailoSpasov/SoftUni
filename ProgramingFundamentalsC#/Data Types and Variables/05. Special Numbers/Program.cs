using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());


            for (int ExactNumber = 1; ExactNumber <= range; ExactNumber++)
            {
                int sum = 0;
                int number = ExactNumber;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                bool trueOrFalse = false;
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    trueOrFalse = true;
                }
                Console.WriteLine($"{ExactNumber} -> {trueOrFalse}");
            }

        }
    }
}
