using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>();
            while (input[0] != "END")
            {
                if (input[0] == "Pop")
                {
                    stack.Pop();
                }
                else
                {
                    string joind = string.Join("", input.Skip(1));
                    string[] splited = joind.Split(",");
                    for (int i = 0; i < splited.Length; i++)
                    {
                        stack.Push(splited[i]);
                    }
                }
                input = Console.ReadLine().Split();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

        }
    }
}
