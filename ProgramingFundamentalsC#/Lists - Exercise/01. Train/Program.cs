using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int capacity = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    int pasangers = int.Parse(input[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + pasangers <= capacity)
                        {
                            wagons[i] += pasangers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(" ",wagons));
        }
    }
}
