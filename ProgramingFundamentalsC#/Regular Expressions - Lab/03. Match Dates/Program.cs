using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b([0-9]{2})([-.\/])([A-Z][a-z]{2})\2([0-9]{4}\b)";
            MatchCollection matchedDates = Regex.Matches(input, @"\b([0-9]{2})([-.\/])([A-Z][a-z]{2})\2([0-9]{4}\b)");
            foreach (Match match in matchedDates)
            {
                Console.Write($"Day: {match.Groups[1]}, Month: {match.Groups[3]}, Year: {match.Groups[4]}");
                Console.WriteLine();
            }
        }
    }
}
