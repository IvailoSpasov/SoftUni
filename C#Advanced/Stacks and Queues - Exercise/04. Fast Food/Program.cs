using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            Queue<int> clients = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Console.WriteLine(clients.Max());

            while (true)
            {
                if (clients.Count == 0)
                {
                    break;
                }
                if (quantityOfFood - clients.Peek() >= 0)
                {
                    quantityOfFood -= clients.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ",clients)}");
                    return;
                }

            }

            Console.WriteLine("Orders complete");
        }
    }
}
