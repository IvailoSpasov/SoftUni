﻿using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int nappyNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i]+numbers[j] == nappyNumber)
                    {
                        Console.WriteLine(numbers[i]+" "+numbers[j]);
                    }
                }
            }
        }
    }
}
