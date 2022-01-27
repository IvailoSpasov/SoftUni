using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char firstLetter = input[i][0];
                char lastLetter = input[i][input[i].Length - 1];
                string n = input[i].Remove(0, 1);
                n = n.Remove(n.Length - 1, 1);
                double number = int.Parse(n);
                double firstResult = 0;
                double secondResult = 0;
                if (char.IsUpper(firstLetter))
                {
                    firstResult = number / (firstLetter - 64);
                }
                else
                {
                    firstResult = number * (firstLetter - 96);
                }
                if (char.IsUpper(lastLetter))
                {
                    secondResult = firstResult - (lastLetter - 64);
                }
                else
                {
                    secondResult = firstResult + (lastLetter - 96);
                }
                sum += secondResult;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
