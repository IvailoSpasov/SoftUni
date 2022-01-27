using System;

namespace _06._Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            double dayAway = double.Parse(Console.ReadLine());
            double kgFood = double.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine());

            double dogFuudNeeded = dayAway * dogFoodPerDay;
            double catFoodNeeded = dayAway * catFoodPerDay;
            double turtleFoodNeeded = dayAway * (turtleFoodPerDay / 1000);

            double totalFoodNeeded = dogFuudNeeded + catFoodNeeded + turtleFoodNeeded;

            if (totalFoodNeeded <= kgFood)
            {
                Console.WriteLine($"{Math.Floor(kgFood - totalFoodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeeded - kgFood)} more kilos of food are needed.");
            }


        }
    }
}
