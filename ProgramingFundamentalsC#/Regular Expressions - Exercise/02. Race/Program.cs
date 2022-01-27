using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Dictionary<string, int> results = new Dictionary<string, int>();
            for (int i = 0; i < input.Length; i++)
            {
                results.Add(input[i], 0);
            }

            Regex regexForName = new Regex(@"[A-Za-z]");
            Regex regexForDistance = new Regex(@"[0-9]");
            string nameDistance = Console.ReadLine();
            while (nameDistance != "end of race")
            {
                MatchCollection matchedName = regexForName.Matches(nameDistance);
                string name = string.Join("", matchedName);
                MatchCollection matchedKilometers = regexForDistance.Matches(nameDistance);
                string distance = string.Join("", matchedKilometers);
                int kilometers = 0;
                for (int i = 0; i < distance.Length; i++)
                {
                    kilometers += int.Parse(distance[i].ToString());
                }
                if (results.ContainsKey(name))
                {
                    results[name] += kilometers;
                }
                nameDistance = Console.ReadLine();

            }

            List<string> firstThree = new List<string>();
            foreach (var participant in results.OrderByDescending(x=>x.Value).Take(3))
            {
                firstThree.Add(participant.Key);
            }

            Console.WriteLine($"1st place: {firstThree[0]}");
            Console.WriteLine($"2nd place: {firstThree[1]}");
            Console.WriteLine($"3rd place: {firstThree[2]}");
        }
    }
}
