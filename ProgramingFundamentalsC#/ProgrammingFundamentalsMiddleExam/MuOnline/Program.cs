using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("|").ToArray();
            int health = 100;
            double bitcoins = 0;
            for (int room = 0; room < input.Length; room++)
            {
                string[] cmd = input[room].Split().ToArray();
                if (cmd[0] == "potion")
                {
                    int prevHealth = health;
                    health += int.Parse(cmd[1]);
                    if (health > 100)
                    {
                        health = 100;
                    }

                    int amount = health - prevHealth;
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (cmd[0]== "chest")
                {
                    bitcoins += int.Parse(cmd[1]);
                    Console.WriteLine($"You found {cmd[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(cmd[1]);
                    if (health<=0)
                    {
                        Console.WriteLine($"You died! Killed by {cmd[0]}.");
                        Console.WriteLine($"Best room: {room+1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {cmd[0]}.");
                    }
                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
