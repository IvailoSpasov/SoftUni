using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Coffee_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cofees = Console.ReadLine().Split().ToList();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "Include")
                {
                    cofees.Add(commands[1]);
                }
                else if (commands[0] == "Remove")
                {
                    int numberOfCofees = int.Parse(commands[2]);
                    if (numberOfCofees <= cofees.Count)
                    {
                        if (commands[1] == "first")
                        {
                            cofees.RemoveRange(0, numberOfCofees);
                        }
                        else if (commands[1] == "last")
                        {
                            for (int j = 0; j < numberOfCofees; j++)
                            {
                                cofees.RemoveAt(cofees.Count-1);
                            }
                        }
                    }
                }
                else if (commands[0] == "Prefer")
                {
                    int indexOne = int.Parse(commands[1]);
                    int indexTwo = int.Parse(commands[2]);
                    if (indexOne >= 0 && indexOne < cofees.Count && indexTwo >= 0 && indexTwo < cofees.Count)
                    {
                        string temp = cofees[indexOne];
                        cofees[indexOne] = cofees[indexTwo];
                        cofees[indexTwo] = temp;
                    }
                }
                else if (commands[0]=="Reverse")
                {
                    cofees.Reverse();
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ",cofees));
        }
    }
}
