using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([=\/])(?<destination>[A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = regex.Matches(input);
            List<string> destinationsList = new List<string>();
            int points = 0;
            foreach (Match destination in matches)
            {
                points += destination.Groups["destination"].ToString().Length;
                destinationsList.Add(destination.Groups["destination"].ToString());
            }

            Console.WriteLine($"Destinations: {string.Join(", ",destinationsList)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
