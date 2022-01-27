using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            Dictionary<string, int> items = new Dictionary<string, int>();

            while (item != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(item))
                {
                    items.Add(item,0);
                }

                items[item] += quantity;
                item = Console.ReadLine();
            }

            foreach (var itm in items)
            {
                Console.WriteLine($"{itm.Key} -> {itm.Value}");
            }
        }
    }
}
