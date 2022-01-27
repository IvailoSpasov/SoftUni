using System;

namespace _06._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statistNumber = int.Parse(Console.ReadLine());
            double clothesPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.1;
            double totalClothesPrice = clothesPrice * statistNumber;
            if (statistNumber > 150)
            {
                totalClothesPrice -= totalClothesPrice * 0.1;
            }
            double totalMoneyNeeded = totalClothesPrice + decor;
            if (budget > totalMoneyNeeded)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalMoneyNeeded:F2} leva left.");
            }
            else if (budget < totalMoneyNeeded)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalMoneyNeeded - budget:F2} leva more.");
            }
        }
    }
}
