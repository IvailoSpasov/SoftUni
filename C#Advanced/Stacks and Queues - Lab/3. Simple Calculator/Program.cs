using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>(Console.ReadLine().Split().Reverse().ToArray());

            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                string action = stack.Pop();
                int secondNum = int.Parse(stack.Pop());
                if (action == "+")
                {
                    stack.Push((firstNum+secondNum).ToString());
                }
                else
                {
                    stack.Push((firstNum-secondNum).ToString());
                }
            }

            int result = int.Parse(stack.Pop());
            Console.WriteLine(result);
        }
    }
}
