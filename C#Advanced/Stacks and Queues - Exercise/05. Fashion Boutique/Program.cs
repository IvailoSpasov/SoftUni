using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int rackCapacity = int.Parse(Console.ReadLine());
            int currRack = 0;
            int numberOfRacks = 1;

            while (clothes.Count != 0)
            {
                if (currRack + clothes.Peek() > rackCapacity)
                {
                    numberOfRacks++;
                    currRack = 0;
                }

                currRack += clothes.Pop();
            }

            Console.WriteLine(numberOfRacks);

        }
    }
}
