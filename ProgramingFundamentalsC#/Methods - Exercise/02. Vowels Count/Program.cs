using System;
using System.Diagnostics.Tracing;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            FindNumberOfVowels(input);
        }

        private static void FindNumberOfVowels(string input)
        {
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if ("auoei".Contains(input[i]))
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}