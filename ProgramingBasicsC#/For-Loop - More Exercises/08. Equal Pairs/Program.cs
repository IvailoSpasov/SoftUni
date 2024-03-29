﻿using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            double difference = 0;
            double maxDifference = 0;

            for (int i = 0; i < n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double currentSum = num1 + num2;
                if (i == 0)
                {
                    sum = currentSum;
                }
                else
                {
                    difference = Math.Abs(sum - currentSum);
                    sum = currentSum;
                }
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                }
            }
            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDifference}");
            }
        }
    }
}
