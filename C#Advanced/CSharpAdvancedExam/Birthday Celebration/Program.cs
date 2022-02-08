using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> food = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int wastedFood = 0;
            while (guests.Count != 0 && food.Count != 0)
            {
                int currGuest = guests.Peek();
                while (currGuest > 0)
                {
                    int currFood = food.Pop();
                    currGuest -= currFood;
                }

                wastedFood += Math.Abs(currGuest);
                guests.Dequeue();
            }

            if (guests.Count == 0)
            {
                Console.Write($"Plates: ");
                for (int i = 0; i < food.Count; i++)
                {
                    Console.Write($"{food.Pop()} ");
                }

                Console.WriteLine();

                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
            else
            {
                Console.WriteLine($"Guests: {string.Join(" ",guests)}");
                Console.WriteLine($"Wasted grams of food: {wastedFood}");
            }
        }
    }
}
