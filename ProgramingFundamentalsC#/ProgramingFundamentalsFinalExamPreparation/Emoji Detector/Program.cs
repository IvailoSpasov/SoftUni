using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regexForNumbers = new Regex(@"[0-9]");
            Regex regexForEmoji = new Regex(@"([\:]{2}|[\*]{2})(?<emoji>[A-Z][a-z]{2,})\1");
            BigInteger treshold = 1;
            MatchCollection numberMatches = regexForNumbers.Matches(input);
            foreach (Match number in numberMatches)
            {
                treshold *= int.Parse(number.ToString());
            }

            MatchCollection emojiMatches = regexForEmoji.Matches(input);
            List<string> coolEmojis = new List<string>();
            foreach (Match emojiMatch in emojiMatches)
            {
                BigInteger emojiCoolNumber = 0;
                string emojii = emojiMatch.Groups["emoji"].ToString();
                for (int i = 0; i < emojii.Length; i++)
                {
                    emojiCoolNumber += emojii[i];
                }

                if (emojiCoolNumber>treshold)
                {
                    coolEmojis.Add(emojiMatch.ToString());
                }
            }

            Console.WriteLine($"Cool threshold: {treshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
