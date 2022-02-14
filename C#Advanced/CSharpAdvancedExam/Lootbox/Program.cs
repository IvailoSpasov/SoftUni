using System;
using System.Collections.Generic;
using System.Linq;

namespace Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> boxesQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> boxeStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int claimedItems = 0;
            while (boxeStack.Count > 0 && boxesQueue.Count > 0)
            {
                if ((boxeStack.Peek() + boxesQueue.Peek()) % 2 == 0)
                {
                    claimedItems += (boxeStack.Pop() + boxesQueue.Dequeue());
                }
                else
                {
                    boxesQueue.Enqueue(boxeStack.Pop());
                }
            }

            if (boxeStack.Count==0)
            {
                Console.WriteLine("Second lootbox is empty");
            }
            else
            {
                Console.WriteLine("First lootbox is empty");
            }

            if (claimedItems>100)
            {
                Console.WriteLine($"Your loot was epic! Value: {claimedItems}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {claimedItems}");
            }
        }
    }
}
