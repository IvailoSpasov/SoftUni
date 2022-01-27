using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.Replace(" ", "");

            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!counts.ContainsKey(text[i]))
                {
                    counts.Add(text[i],0);
                }

                counts[text[i]]++;
            }

            foreach (var letter in counts)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
