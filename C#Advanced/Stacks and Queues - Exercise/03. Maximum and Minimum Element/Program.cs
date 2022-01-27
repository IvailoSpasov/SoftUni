using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = input[0];
                if (action == 1)
                {
                    int number = input[1];
                    stack.Push(number);
                }
                else if (action == 2 && stack.Count > 0)
                {
                    stack.Pop();
                }
                else if (action == 3 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Max());
                }
                else if (action == 4 && stack.Count > 0)
                {
                    Console.WriteLine(stack.Min());
                }


            }

            Console.WriteLine(string.Join(", ",stack));
        }
    }
}
