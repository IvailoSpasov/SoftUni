using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> peopleList = new Queue<string>();
            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (peopleList.Count != 0)
                    {
                        Console.WriteLine(peopleList.Dequeue());
                    }
                }
                else
                {
                    peopleList.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{peopleList.Count} people remaining.");
        }
    }
}
