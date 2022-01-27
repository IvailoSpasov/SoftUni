using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherman = int.Parse(Console.ReadLine());

            int rent = 0;
            double discount = 0;

            if (fisherman <= 6)
            {
                discount = 0.1;
            }
            else if (fisherman >= 7 && fisherman <= 11)
            {
                discount = 0.15;
            }
            else if (fisherman >= 12)
            {
                discount = 0.25;
            }

            switch (season)
            {
                case "Spring":
                    rent = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    rent = 4200;
                    break;
                case "Winter":
                    rent = 2600;
                    break;
            }
            double price = rent - (rent * discount);
            double secondDiscount = 0;

            if ((fisherman % 2 == 0) && season != "Autumn")
            {
                secondDiscount = 0.05;
            }
            double totalPrice = price - (price * secondDiscount);

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }



        }
    }
}
