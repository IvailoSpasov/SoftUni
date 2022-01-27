using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([@#])(?<firstWord>[A-Za-z]{3,})\1\1(?<secondWord>[A-Za-z]{3,})\1");
            MatchCollection matches = regex.Matches(input);
            List<string> mirrorWords = new List<string>();
            int numberOfmirrorWords = matches.Count;
            int valid = 0;
            foreach (Match match in matches)
            {
                string firstWord = match.Groups["firstWord"].ToString();
                string secondWord = match.Groups["secondWord"].ToString();
                string reversed = string.Join("", secondWord.Reverse());
                if (firstWord == reversed)
                {
                    valid++;
                    mirrorWords.Add($"{firstWord} <=> {secondWord}");
                }
            }

            if (numberOfmirrorWords == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{numberOfmirrorWords} word pairs found!");
                if (valid == 0)
                {
                    Console.WriteLine("No mirror words!");
                }
                else
                {

                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
            }
        }
    }
}
