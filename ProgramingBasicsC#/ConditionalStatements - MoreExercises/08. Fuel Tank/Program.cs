using System;

namespace _08._Fuel_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double litersOfFuel = double.Parse(Console.ReadLine());

            if (fuel == "Diesel")
            {
                if (litersOfFuel >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if (fuel == "Gasoline")
            {
                if (litersOfFuel >= 25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (fuel == "Gas")
            {
                if (litersOfFuel >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gas!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
