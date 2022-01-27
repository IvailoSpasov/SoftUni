using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string[] commands = Console.ReadLine().Split(" - ").ToArray();


            while (commands[0] != "Craft!")
            {
                if (commands[0] == "Collect")
                {
                    if (!items.Contains(commands[1]))
                    {
                        items.Add(commands[1]);
                    }
                }
                else if (commands[0]== "Drop")
                {
                    if (items.Contains(commands[1]))
                    {
                        items.Remove(commands[1]);
                    }
                }
                else if (commands[0]== "Combine Items")
                {
                    string[] itemsToCombine = commands[1].Split(":").ToArray();
                    if (items.Contains(itemsToCombine[0]))
                    {
                        int index = items.IndexOf(itemsToCombine[0]);
                        items.Insert(index+1, itemsToCombine[1]);
                    }
                }
                else if (commands[0]== "Renew")
                {
                    if (items.Contains(commands[1]))
                    {
                        items.Remove(commands[1]);
                        items.Add(commands[1]);
                    }
                }
                commands = Console.ReadLine().Split(" - ").ToArray();
            }

            Console.WriteLine(string.Join(", ",items));
        }
    }
}
