using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] steelArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] carbonArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> steelQueue = new Queue<int>(steelArray);
            Stack<int> carbonStack = new Stack<int>(carbonArray);
            Dictionary<string, int> forgedSwords = new Dictionary<string, int>();
            int forgedSwordsCount = 0;
            while (steelQueue.Count != 0 && carbonStack.Count != 0)
            {
                int metal = steelQueue.Peek() + carbonStack.Peek();
                string sword = String.Empty;

                switch (metal)
                {
                    case 70:
                        sword = "Gladius";
                        break;
                    case 80:
                        sword = "Shamshir";
                        break;
                    case 90:
                        sword = "Katana";
                        break;
                    case 110:
                        sword = "Sabre";
                        break;
                    case 150:
                        sword = "Broadsword";
                        break;
                }

                if (sword != String.Empty)
                {
                    forgedSwordsCount++;
                    carbonStack.Pop();
                    steelQueue.Dequeue();
                    if (!forgedSwords.ContainsKey(sword))
                    {
                        forgedSwords.Add(sword, 0);
                    }
                    forgedSwords[sword]++;
                }
                else
                {
                    steelQueue.Dequeue();
                    int carbonTemp = carbonStack.Pop();
                    carbonStack.Push(carbonTemp + 5);
                }
            }

            if (forgedSwords.Count > 0)
            {
                Console.WriteLine($"You have forged {forgedSwordsCount} swords.");
            }
            else
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }

            if (steelQueue.Count > 0)
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steelQueue)}");
            }
            else
            {
                Console.WriteLine("Steel left: none");
            }

            if (carbonStack.Count > 0)
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbonStack)}");
            }
            else
            {
                Console.WriteLine("Carbon left: none");
            }

            if (forgedSwords.Count > 0)
            {
                foreach (var sword in forgedSwords.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{sword.Key}: {sword.Value}");
                }
            }

            SomeMethod(forgedSwordsCount);
        }

        private static void SomeMethod(int forgedSwordsCount)
        {
            throw new NotImplementedException();
        }
    }
}
