using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> occurrancesDictionary = new SortedDictionary<char, int>();

            foreach (var letter in input)
            {
                if (!occurrancesDictionary.ContainsKey(letter))
                {
                    occurrancesDictionary.Add(letter,0);
                }

                occurrancesDictionary[letter]++;
            }
            //S: 1 time/s
            foreach (var letter in occurrancesDictionary)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
