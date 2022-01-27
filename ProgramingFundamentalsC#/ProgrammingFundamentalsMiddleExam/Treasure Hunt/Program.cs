using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tresures = Console.ReadLine().Split("|").ToList();
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "Yohoho!")
            {
                if (commands[0] == "Loot")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        if (!tresures.Contains(commands[i]))
                        {
                            tresures.Insert(0, commands[i]);
                        }
                    }
                }
                else if (commands[0] == "Drop")
                {
                    if (int.Parse(commands[1]) >= 0 && int.Parse(commands[1]) < tresures.Count)
                    {
                        tresures.Add(tresures[int.Parse(commands[1])]);
                        tresures.RemoveAt(int.Parse(commands[1]));
                    }
                }
                else if (commands[0] == "Steal")
                {
                    List<string> removedItems = new List<string>();
                    int finalcount = int.Parse(commands[1]);
                    if (finalcount >= tresures.Count)
                    {
                        finalcount = tresures.Count;
                    }

                    for (int i = 0; i < finalcount; i++)
                    {
                        removedItems.Insert(0, tresures[tresures.Count - 1]);
                        tresures.RemoveAt(tresures.Count - 1);
                    }

                    Console.WriteLine(string.Join(", ", removedItems));
                }
                commands = Console.ReadLine().Split().ToArray();
            }

            if (tresures.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
                return;
            }

            double countOfLetters = 0;

            foreach (var tresure in tresures)
            {
                countOfLetters += tresure.Length;
            }

            double averageGain = countOfLetters / tresures.Count;
            Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
        }
    }
}
