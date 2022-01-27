using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfComands; i++)
            {
                string[] comand = Console.ReadLine().Split().ToArray();
                if (comand[2] == "going!")
                {
                    if (guests.Contains(comand[0]))
                    {
                        Console.WriteLine($"{comand[0]} is already in the list!");
                    }
                    else
                    {
                        guests.Add(comand[0]);
                    }
                }
                else
                {
                    if (guests.Contains(comand[0]))
                    {
                        guests.Remove(comand[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{comand[0]} is not in the list!");
                    }
                }

            }

            Console.WriteLine(string.Join("\n",guests));
        }
    }
}
