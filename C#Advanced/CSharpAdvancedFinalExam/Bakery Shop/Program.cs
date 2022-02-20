using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<double> watersQueue = new Queue<double>(Console.ReadLine().Split().Select(double.Parse));
            Stack<double> floursStack = new Stack<double>(Console.ReadLine().Split().Select(double.Parse));

            Dictionary<string, int> products = new Dictionary<string, int>();

            while (watersQueue.Count > 0 && floursStack.Count > 0)
            {
                double water = watersQueue.Dequeue();
                double flour = floursStack.Peek();

                double totalMix = water + flour;
                double waterPercent = (water * 100) / totalMix;

                if (waterPercent==50)
                {
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant",0);
                    }

                    products["Croissant"]++;
                    floursStack.Pop();
                }
                else if (waterPercent==40)
                {
                    if (!products.ContainsKey("Muffin"))
                    {
                        products.Add("Muffin", 0);
                    }

                    products["Muffin"]++;
                    floursStack.Pop();
                }
                else if (waterPercent == 30)
                {
                    if (!products.ContainsKey("Baguette"))
                    {
                        products.Add("Baguette", 0);
                    }

                    products["Baguette"]++;
                    floursStack.Pop();
                }
                else if (waterPercent == 20)
                {
                    if (!products.ContainsKey("Bagel"))
                    {
                        products.Add("Bagel", 0);
                    }

                    products["Bagel"]++;
                    floursStack.Pop();
                }
                else
                {
                    floursStack.Pop();
                    double flourToAddBack = flour - water;
                    floursStack.Push(flourToAddBack);
                    if (!products.ContainsKey("Croissant"))
                    {
                        products.Add("Croissant", 0);
                    }

                    products["Croissant"]++;
                }

            }

            foreach (var product in products.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }

            if (watersQueue.Count>0)
            {
                Console.WriteLine($"Water left: {string.Join(", ",watersQueue)}");
            }
            else
            {
                Console.WriteLine("Water left: None");
            }

            if (floursStack.Count>0)
            {
                Console.WriteLine($"Flour left: {string.Join(", ",floursStack)}");
            }
            else
            {
                Console.WriteLine("Flour left: None");
            }
        }
    }
}
