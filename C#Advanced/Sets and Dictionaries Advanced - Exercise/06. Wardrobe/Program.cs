using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(",");
                FilingWardrobe(wardrobe, color, clothes);
            }

            string[] clothWeLookingFor = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string clothColor = clothWeLookingFor[0];
            string cloth = clothWeLookingFor[1];
            PrintingResult(wardrobe, clothColor, cloth);
        }

        private static void PrintingResult(Dictionary<string, Dictionary<string, int>> wardrobe, string clothColor, string cloth)
        {
            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var kvp in color.Value)
                {
                    if (color.Key == clothColor && kvp.Key == cloth)
                    {
                        Console.WriteLine($" * {kvp.Key} - {kvp.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($" * {kvp.Key} - {kvp.Value}");
                    }
                }
            }
        }

        private static void FilingWardrobe(Dictionary<string, Dictionary<string, int>> wardrobe, string color, string[] clothes)
        {
            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }

            foreach (var clothe in clothes)
            {
                if (!wardrobe[color].ContainsKey(clothe))
                {
                    wardrobe[color].Add(clothe, 0);
                }

                wardrobe[color][clothe]++;
            }
        }
    }
}
