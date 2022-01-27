using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] actions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int elementsToPush = actions[0];
            int elementsToPop = actions[1];
            int specialNumber = actions[2];
            int[] elements = (Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                queue.Enqueue(elements[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}