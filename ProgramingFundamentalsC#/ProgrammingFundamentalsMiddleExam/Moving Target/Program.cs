using System;
using System.Collections.Generic;
using System.Linq;

namespace Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] input = Console.ReadLine().Split().ToArray();

            while (input[0] != "End")
            {
                if (input[0] == "Shoot")
                {
                    int index = int.Parse(input[1]);
                    int shootingPower = int.Parse(input[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= shootingPower;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (input[0]== "Add")
                {
                    int index = int.Parse(input[1]);
                    int value = int.Parse(input[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index,value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (input[0]== "Strike")
                {
                    int index = int.Parse(input[1]);
                    int radius = int.Parse(input[2]);
                    if (index-radius >= 0 && index+radius < targets.Count)
                    {
                        targets.RemoveRange((index-radius),radius*2+1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join("|",targets));
        }
    }
}
