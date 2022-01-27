using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kilometers = double.Parse(Console.ReadLine());

            double levaPerKilometer = 0;

            if (kilometers <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        levaPerKilometer = 0.75;
                        break;
                    case "Summer":
                        levaPerKilometer = 0.90;
                        break;
                    case "Winter":
                        levaPerKilometer = 1.05;
                        break;
                }
            }
            else if (kilometers <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        levaPerKilometer = 0.95;
                        break;
                    case "Summer":
                        levaPerKilometer = 1.10;
                        break;
                    case "Winter":
                        levaPerKilometer = 1.25;
                        break;
                }
            }
            else if (kilometers <= 20000)
            {
                levaPerKilometer = 1.45;
            }

            double profit = (kilometers * levaPerKilometer * 4) * 0.9;
            Console.WriteLine($"{profit:f2}");
        }
    }
}
