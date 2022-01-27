using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, Dictionary<string, HashSet<string>>> vLogger =
                new Dictionary<string, Dictionary<string, HashSet<string>>>();
            while (input[0] != "Statistics")
            {
                if (input[1] == "joined" && !vLogger.ContainsKey(input[0]))
                {
                    vLogger.Add(input[0], new Dictionary<string, HashSet<string>>());
                    vLogger[input[0]].Add("fowowers", new HashSet<string>());
                    vLogger[input[0]].Add("followings", new HashSet<string>());
                }
                else if (input[1] == "followed")
                {
                    string nameOfFowower = input[0];
                    string nameToFowow = input[2];
                    AddFowower(vLogger, nameOfFowower, nameToFowow);
                }
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            }

            Console.WriteLine($"The V-Logger has a total of {vLogger.Count} vloggers in its logs.");
            int k = 2;
            foreach (var kvp in vLogger.OrderByDescending(x => x.Value["fowowers"].Count).ThenBy(x => x.Value["followings"].Count).Take(1))
            {
                Console.WriteLine($"1. {kvp.Key} : {kvp.Value["fowowers"].Count} followers, {kvp.Value["followings"].Count} following");
                if (kvp.Value["fowowers"].Count > 0)
                {
                    foreach (var fowower in kvp.Value["fowowers"].OrderBy(x=>x))
                    {
                        Console.WriteLine($"*  {fowower}");
                    }
                }

                vLogger.Remove(kvp.Key);
            }

            foreach (var kvp in vLogger.OrderByDescending(x=>x.Value["fowowers"].Count).ThenBy(x=>x.Value["followings"].Count))
            {
                Console.WriteLine($"{k}. {kvp.Key} : {kvp.Value["fowowers"].Count} followers, {kvp.Value["followings"].Count} following");
                k++;
            }

        }

        private static void AddFowower(Dictionary<string, Dictionary<string, HashSet<string>>> vLogger, string nameOfFowower, string nameToFowow)
        {
            if (vLogger.ContainsKey(nameOfFowower) && vLogger.ContainsKey(nameToFowow) && nameToFowow != nameOfFowower && !vLogger[nameOfFowower]["followings"].Contains(nameToFowow))
            {
                vLogger[nameToFowow]["fowowers"].Add(nameOfFowower);
                vLogger[nameOfFowower]["followings"].Add(nameToFowow);
            }
        }
    }


}
