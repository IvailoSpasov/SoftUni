using System;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingrediants = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> freshnesLevel = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> dishes = new Dictionary<string, int>();

            while (ingrediants.Count > 0 && freshnesLevel.Count > 0)
            {
                if (ingrediants.Peek() == 0)
                {
                    ingrediants.Dequeue();
                    continue;
                }

                int sum = freshnesLevel.Pop() * ingrediants.Peek();
                if (sum == 150 || sum == 250 || sum == 300 || sum == 400)
                {
                    string dishName = String.Empty;
                    switch (sum)
                    {
                        case 150:
                            dishName = "Dipping sauce";
                            break;
                        case 250:
                            dishName = "Green salad";
                            break;
                        case 300:
                            dishName = "Chocolate cake";
                            break;
                        case 400:
                            dishName = "Lobster";
                            break;
                    }

                    if (!dishes.ContainsKey(dishName))
                    {
                        dishes.Add(dishName, 0);
                    }

                    dishes[dishName]++;
                    ingrediants.Dequeue();
                }
                else
                {
                    int newIngrediant = ingrediants.Dequeue() + 5;
                    ingrediants.Enqueue(newIngrediant);
                }
            }

            if (dishes.Count == 4)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
            }

            if (ingrediants.Count>0)
            {
                Console.WriteLine($"Ingredients left: {ingrediants.Sum()}");
            }

            foreach (var dish in dishes.OrderBy(x=>x.Key))
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value}");
            }
        }
    }
}
