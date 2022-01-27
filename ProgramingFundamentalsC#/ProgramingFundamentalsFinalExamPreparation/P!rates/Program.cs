using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class City
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            Dictionary<string, City> cityes = new Dictionary<string, City>();
            while (input[0] != "Sail")
            {
                string city = input[0];
                int population = int.Parse(input[1]);
                int gold = int.Parse(input[2]);
                if (!cityes.ContainsKey(city))
                {
                    cityes.Add(city, new City());
                }

                cityes[city].Population += population;
                cityes[city].Gold += gold;
                input = Console.ReadLine().Split("||");
            }

            string[] commands = Console.ReadLine().Split("=>");
            while (commands[0] != "End")
            {
                string cmd = commands[0];
                if (cmd == "Plunder")
                {
                    string town = commands[1];
                    int people = int.Parse(commands[2]);
                    int gold = int.Parse(commands[3]);
                    cityes[town].Population -= people;
                    cityes[town].Gold -= gold;
                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cityes[town].Population == 0 || cityes[town].Gold == 0)
                    {
                        cityes.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (cmd == "Prosper")
                {
                    string town = commands[1];
                    int gold = int.Parse(commands[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cityes[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cityes[town].Gold} gold.");
                    }
                }
                commands = Console.ReadLine().Split("=>");
            }

            if (cityes.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cityes.Count} wealthy settlements to go to:");
                foreach (var city in cityes.OrderByDescending(x=>x.Value.Gold).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }

        }
    }
}
