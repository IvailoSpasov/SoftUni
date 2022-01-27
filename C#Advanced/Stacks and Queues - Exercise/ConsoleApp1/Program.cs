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
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < elementsToPush; i++)
            {
                stack.Push(elements[i]);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
