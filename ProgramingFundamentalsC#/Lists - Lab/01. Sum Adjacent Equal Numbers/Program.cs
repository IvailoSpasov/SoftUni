﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                    double sum = 0;
                    if (numbers[i] == numbers[i+1])
                    {
                        sum = numbers[i] + numbers[i+1];
                        numbers.Insert(i,sum);
                        numbers.RemoveAt(i+1);
                        numbers.RemoveAt(i+1);
                        i=-1;
                    }

            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}