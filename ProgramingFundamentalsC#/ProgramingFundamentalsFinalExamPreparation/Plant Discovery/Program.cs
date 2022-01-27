using System;
using System.Collections.Generic;
using System.Linq;

namespace Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double[]> plantRarity = new Dictionary<string, double[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                string plant = input[0];
                int rarity = int.Parse(input[1]);
                if (!plantRarity.ContainsKey(plant))
                {
                    plantRarity.Add(plant, new double[2]);
                }

                plantRarity[plant][0] = rarity;
            }

            string[] commands = Console.ReadLine().Split(": ");
            Dictionary<string, List<double>> plantRating = new Dictionary<string, List<double>>();
            while (commands[0] != "Exhibition")
            {
                string cmd = commands[0];
                if (cmd == "Rate")
                {
                    string[] plantRate = commands[1].Split(" - ");
                    double rating = double.Parse(plantRate[1]);
                    string plant = plantRate[0];
                    if (plantRarity.ContainsKey(plant))
                    {
                        if (!plantRating.ContainsKey(plant))
                        {
                            plantRating.Add(plant, new List<double>());
                        }

                        plantRating[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "Update")
                {
                    string[] plantRare = commands[1].Split(" - ");
                    int rarity = int.Parse(plantRare[1]);
                    string plant = plantRare[0];
                    if (plantRarity.ContainsKey(plant))
                    {
                        plantRarity[plant][0] = rarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "Reset")
                {
                    string plant = commands[1];
                    if (plantRating.ContainsKey(plant))
                    {
                        plantRating[plant].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                commands = Console.ReadLine().Split(": ");
            }

            Dictionary<string, double> avgRating = new Dictionary<string, double>();
            foreach (var plant in plantRating)
            {
                if (plantRating[plant.Key].Count == 0)
                {
                    plantRating[plant.Key].Add(0);
                }
                avgRating.Add(plant.Key, plant.Value.Average());
            }


            foreach (var plant in avgRating)
            {
                plantRarity[plant.Key][1] = plant.Value;
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantRarity.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {plant.Value[1]:f2}");
            }
        }
    }
}
