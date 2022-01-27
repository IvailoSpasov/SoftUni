using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> continentsAndCountries =
                new Dictionary<string, Dictionary<string, List<string>>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string continent = input[0];
                string countrie = input[1];
                string town = input[2];
                if (!continentsAndCountries.ContainsKey(continent))
                {
                    continentsAndCountries.Add(continent, new Dictionary<string, List<string>>());
                }
                if (!continentsAndCountries[continent].ContainsKey(countrie))
                {
                    continentsAndCountries[continent].Add(countrie, new List<string>());
                    continentsAndCountries[continent][countrie].Add(town);
                }
                else
                {
                    continentsAndCountries[continent][countrie].Add(town);

                }

            }

            foreach (var continents in continentsAndCountries)
            {
                Console.WriteLine($"{continents.Key}:");
                foreach (var countries in continents.Value)
                {
                    Console.WriteLine($"  {countries.Key} -> {string.Join(", ", countries.Value)}");
                }
            }
        }
    }
}
