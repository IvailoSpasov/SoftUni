using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysMissing = int.Parse(Console.ReadLine());
            int foodLeftKg = int.Parse(Console.ReadLine());
            double firstDeerFoodPerDay = double.Parse(Console.ReadLine());
            double secondDeerFoodPerDay = double.Parse(Console.ReadLine());
            double thirdDeerFoodPerDay = double.Parse(Console.ReadLine());

            double foodNeeded = (daysMissing * firstDeerFoodPerDay) + (daysMissing * secondDeerFoodPerDay) + (daysMissing * thirdDeerFoodPerDay);

            if (foodLeftKg >= foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeftKg - foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded - foodLeftKg)} more kilos of food are needed.");
            }
        }
    }
}
