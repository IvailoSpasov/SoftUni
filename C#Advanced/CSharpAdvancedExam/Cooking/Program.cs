using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquidsQueue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingrediantsStack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> foods = new Dictionary<string, int>();

            foods.Add("Bread", 0);
            foods.Add("Cake", 0);
            foods.Add("Pastry", 0);
            foods.Add("Fruit Pie", 0);

            while (liquidsQueue.Count > 0 && ingrediantsStack.Count > 0)
            {
                int foodValue = ingrediantsStack.Peek() + liquidsQueue.Dequeue();
                if (foodValue == 25 || foodValue == 50 || foodValue == 75 || foodValue == 100)
                {

                    string food = String.Empty;
                    switch (foodValue)
                    {
                        case 25:
                            food = "Bread";
                            break;
                        case 50:
                            food = "Cake";
                            break;
                        case 75:
                            food = "Pastry";
                            break;
                        case 100:
                            food = "Fruit Pie";
                            break;
                    }

                    ingrediantsStack.Pop();
                    foods[food]++;
                }
                else
                {
                    ingrediantsStack.Push(ingrediantsStack.Pop() + 3);
                }
            }

            if (foods.Where(x => x.Value > 0).Count() == 4)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquidsQueue.Count>0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ",liquidsQueue)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingrediantsStack.Count>0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ",ingrediantsStack)}");
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }

            foreach (var food in foods.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }
        }
    }
}
