using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);

            while (true)
            {
                for (int i = 0; i < input.Length; i += 2)
                {
                    string item = input[i + 1].ToLower();
                    int quantity = int.Parse(input[i]);

                    if (item == "shards" || item == "fragments" || item == "motes")
                    {
                        items[item] += quantity;
                    }
                    else
                    {
                        if (!junk.ContainsKey(item))
                        {
                            junk.Add(item, 0);
                        }

                        junk[item] += quantity;
                    }

                    if (items.ContainsKey(item))
                    {
                        if (items[item] >= 250)
                        {
                            items[item] -= 250;
                            string currItem = string.Empty;
                            switch (item)
                            {
                                case "shards":
                                    currItem = "Shadowmourne";
                                    break;
                                case "fragments":
                                    currItem = "Valanyr";
                                    break;
                                case "motes":
                                    currItem = "Dragonwrath";
                                    break;
                            }

                            Console.WriteLine($"{currItem} obtained!");
                            foreach (var itm in items.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                            {
                                Console.WriteLine($"{itm.Key}: {itm.Value}");
                            }

                            foreach (var itm in junk.OrderBy(x => x.Key))
                            {
                                Console.WriteLine($"{itm.Key}: {itm.Value}");
                            }

                            return;
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }
        }
    }
}
