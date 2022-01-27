using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([#|])(?<name>[A-Za-z\s]+)\1(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]+)\1");
            MatchCollection matches = regex.Matches(input);
            int totalCalories = 0;
            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].ToString());
            }

            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {

                Console.WriteLine($"Item: {match.Groups["name"]}, Best before: {match.Groups["date"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
}
