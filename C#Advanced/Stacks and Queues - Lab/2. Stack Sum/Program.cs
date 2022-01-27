using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            Stack<int> stack = new Stack<int>(arr);

            while (command[0].ToLower() != "end")
            {
                string cmd = command[0].ToLower();
                if (cmd == "add")
                {
                    int firstNumber = int.Parse(command[1]);
                    int secondNumber = int.Parse(command[2]);
                    stack.Push(firstNumber);
                    stack.Push(secondNumber);
                }
                else if (cmd == "remove")
                {
                    int n = int.Parse(command[1]);
                    if (stack.Count >= n)
                    {

                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }

            int sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
