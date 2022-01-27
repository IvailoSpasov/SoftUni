using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawInput = Console.ReadLine();
            string[] input = rawInput.Split(" ");
            Dictionary<string, string> sides = new Dictionary<string, string>();

            while (rawInput != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] splited = rawInput.Split(" | ");
                    string side = splited[0];
                    string user = splited[1];
                    if (!sides.ContainsKey(side))
                    {
                        sides.Add(user,side);
                    }

                }
                else if (input.Contains("->"))
                {
                    string[] splited = rawInput.Split(" -> ");
                    string side = splited[1];
                    string user = splited[0];
                    if (!sides.ContainsKey(user))
                    {
                        sides.Add(user,side);
                    }
                    else
                    {
                        sides[user] = side;
                    }

                    Console.WriteLine($"{user} joins the {side} side!");

                }
                rawInput = Console.ReadLine();
                input = rawInput.Split(" ");
            }

            foreach (var kvp in sides.GroupBy(x=>x.Value).OrderByDescending(x=>x.Count()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Count()}");

                foreach (var elm in kvp.OrderBy(t => t.Key))
                {
                    Console.WriteLine($"! {elm.Key}");
                }
            }
        }
    }
}
