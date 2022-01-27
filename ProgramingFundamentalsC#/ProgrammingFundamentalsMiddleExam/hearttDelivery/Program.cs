using System;
using System.Collections.Generic;
using System.Linq;

namespace hearttDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbour = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            int position = 0;
            string[] cmd = Console.ReadLine().Split().ToArray();

            while (cmd[0] != "Love!")
            {
                position += int.Parse(cmd[1]);

                if (position >= neighbour.Count)
                {
                    position = 0;
                }

                neighbour[position] -= 2;
                if (neighbour[position] == 0)
                {
                    Console.WriteLine($"Place {position} has Valentine's day.");
                }
                else if (neighbour[position] < 0)
                {
                    Console.WriteLine($"Place {position} already had Valentine's day.");
                }

                cmd = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine($"Cupid's last position was {position}.");
            neighbour.Sort();
            neighbour.Reverse();
            if (neighbour[0] < 2)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int counter = 0;
                foreach (var house in neighbour)
                {
                    if (house > 0)
                    {
                        counter++;
                    }
                }

                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
