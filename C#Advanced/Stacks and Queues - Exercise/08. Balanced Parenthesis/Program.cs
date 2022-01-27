using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            bool isCorekt = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '[' || input[i] == '{' || input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                else
                {
                    if (stack.Count==0)
                    {
                        isCorekt = false;
                        break;
                    }
                    if (input[i] == ']'&&stack.Count>0)
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isCorekt = false;
                            break;
                        }
                    }
                    else if (input[i] == '}' && stack.Count > 0)
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isCorekt = false;
                            break;
                        }
                    }
                    else if (input[i] == ')' && stack.Count > 0)
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isCorekt = false;
                            break;
                        }
                    }
                }
            }

            if (isCorekt && stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
