using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (counts.ContainsKey(words[i].ToLower()))
                {
                    counts[words[i]]++;
                }
                else
                {
                    counts.Add(words[i].ToLower(), 1);
                }
            }

            foreach (var word in counts)
            {
                if (word.Value%2==1)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
