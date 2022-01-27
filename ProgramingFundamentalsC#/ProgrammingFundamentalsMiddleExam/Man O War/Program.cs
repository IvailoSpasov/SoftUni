using System;
using System.Collections.Generic;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealth = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split().ToArray();

            while (commands[0] != "Retire")
            {
                if (commands[0] == "Fire")
                {
                    int index = int.Parse(commands[1]);
                    int damage = int.Parse(commands[2]);
                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }

                }
                else if (commands[0] == "Defend")
                {
                    int startIndex = int.Parse(commands[1]);
                    int endIndex = int.Parse(commands[2]);
                    int damage = int.Parse(commands[3]);
                    if (startIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (commands[0] == "Repair")
                {
                    int index = int.Parse(commands[1]);
                    int health = int.Parse(commands[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }

                }
                else if (commands[0] == "Status")
                {
                    int count = 0;
                    foreach (var section in pirateShip)
                    {
                        if (section < maxHealth * 0.20)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }
                commands = Console.ReadLine().Split().ToArray();

            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }
    }
}
