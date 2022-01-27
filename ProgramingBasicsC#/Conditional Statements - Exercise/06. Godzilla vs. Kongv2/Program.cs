using System;

namespace _06._Godzilla_vs._Kongv2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double priceClothingSt = double.Parse(Console.ReadLine());
            double decor = 0.1 * budget;
            double costClothing = statists * priceClothingSt;

            if (statists > 150)
            {
                priceClothingSt = 0.1 * costClothing;
                costClothing -= priceClothingSt;
            }

            double cost = decor + costClothing;

            if (budget < cost)
            {
                double moneyNeeded = cost - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            else if (budget >= cost)
            {
                double moneyLeft = budget - cost;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }
        }
    }
}
