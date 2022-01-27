using System;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            string word = String.Empty;
            stack.Push(word);
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0];
                if (action == "1")
                {
                    string wordToAppend = command[1];
                    word += wordToAppend;
                    stack.Push(word);
                }
                else if (action == "2")
                {
                    int count = int.Parse(command[1]);
                    word = word.Remove(word.Length - count, count);
                    stack.Push(word);
                }
                else if (action == "3")
                {
                    int index = int.Parse(command[1]);
                    Console.WriteLine(word[index - 1]);
                }
                else if (action == "4")
                {
                    stack.Pop();
                    word = stack.Peek();
                }
            }
        }
    }
}
