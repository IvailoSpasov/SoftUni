using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expresion = Console.ReadLine();
            Stack<int> indexStack = new Stack<int>();

            for (int i = 0; i < expresion.Length; i++)
            {
                if (expresion[i]=='(')
                {
                    indexStack.Push(i);
                }

                if (expresion[i] ==')') 
                {
                    Console.WriteLine(expresion.Substring(indexStack.Peek(),i-indexStack.Pop()+1));
                }
            }
        }
    }
}
