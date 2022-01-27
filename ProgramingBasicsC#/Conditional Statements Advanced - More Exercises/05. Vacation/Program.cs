using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string accommodation = "";
            string country = "";
            double cost = 0;
            if (budget <= 1000)
            {
                accommodation = "Camp";
                if (season == "Summer")
                {
                    country = "Alaska";
                    cost = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                    cost = budget * 0.45;
                }
            }
            else if (budget <= 3000)
            {
                accommodation = "Hut";
                if (season == "Summer")
                {
                    country = "Alaska";
                    cost = budget * 0.8;
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                    cost = budget * 0.6;
                }
            }
            else if (budget > 3000)
            {
                cost = budget * 0.9;
                accommodation = "Hotel";

                if (season == "Summer")
                {
                    country = "Alaska";
                }
                else if (season == "Winter")
                {
                    country = "Morocco";
                }
            }

            Console.WriteLine($"{country} - {accommodation} - {cost:f2}");
        }
    }
}
