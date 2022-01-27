using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            Dictionary<decimal, int> dictionary = new Dictionary<decimal, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary.Add(input[i],0);
                }

                dictionary[input[i]]++;
            }
            

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
