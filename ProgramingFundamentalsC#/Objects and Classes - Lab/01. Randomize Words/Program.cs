﻿using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int randoomIndex = rnd.Next(input.Length - 1);
                string temp = input[i];
                input[i] = input[randoomIndex];
                input[randoomIndex] = temp;
            }

            Console.WriteLine(string.Join("\n",input));
        }
    }
}
