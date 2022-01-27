using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>(Console.ReadLine().Split().ToArray());
            int n = int.Parse(Console.ReadLine());

            while (queue.Count > 1)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    string tempKid = queue.Dequeue();
                    queue.Enqueue(tempKid);
                }

                Console.WriteLine($"Removed {queue.Dequeue()}");
            }

            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
