using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordAndDefinitions = Console.ReadLine().Split(" | ");
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 0; i < wordAndDefinitions.Length; i++)
            {
                string[] words = wordAndDefinitions[i].Split(": ");
                if (!dictionary.ContainsKey(words[0]))
                {
                    dictionary.Add(words[0],new List<string>());
                }

                for (int j = 1; j < words.Length; j++)
                {
                    dictionary[words[0]].Add(words[j]);
                }
            }

            string[] testWords = Console.ReadLine().Split(" | ");
            string command = Console.ReadLine();
            if (command== "Test")
            {
                for (int i = 0; i < testWords.Length; i++)
                {
                    if (dictionary.ContainsKey(testWords[i]))
                    {
                        Console.WriteLine($"{testWords[i]}:");
                        foreach (var word in dictionary[testWords[i]].OrderByDescending(x=>x.Length))
                        {
                            Console.WriteLine($" -{word}");
                        }
                    }
                }
            }
            else
            {
                foreach (var word in dictionary.OrderBy(x=>x.Key))
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}
