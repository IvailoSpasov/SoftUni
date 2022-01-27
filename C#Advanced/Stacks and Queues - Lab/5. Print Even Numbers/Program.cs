using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            List<int> evenNumbers = new List<int>();
            while (queue.Count != 0)
            {
                if (queue.Peek()%2==0)
                {
                    evenNumbers.Add(queue.Peek());
                }

                queue.Dequeue();
            }

            Console.WriteLine(string.Join(", ",evenNumbers));
        }
    }
}
