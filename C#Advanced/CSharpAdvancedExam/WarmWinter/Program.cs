using System;
using System.Collections.Generic;
using System.Linq;

namespace WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hatsStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> scarfsQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            List<int> sets = new List<int>();

            while (hatsStack.Count > 0 && scarfsQueue.Count > 0)
            {
                int hat = hatsStack.Peek();
                int scarf = scarfsQueue.Peek();
                if (hat>scarf)
                {
                    sets.Add((hatsStack.Pop()+scarfsQueue.Dequeue()));
                }
                else if (scarf>hat)
                {
                    hatsStack.Pop();
                }
                else
                {
                    scarfsQueue.Dequeue();
                    hatsStack.Push((hatsStack.Pop()+1));
                }
            }

            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ",sets));
        }
    }
}
