using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (var symbul in input)
            {
                stack.Push(symbul);
            }

            while (stack.Count>0)
            {
                Console.Write(stack.Pop());
            }

        }
    }
}
