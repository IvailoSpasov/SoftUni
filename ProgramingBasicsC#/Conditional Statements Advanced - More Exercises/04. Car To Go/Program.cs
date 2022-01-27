using System;

namespace _04._Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string clas = "";
            string typeVehicle = "";
            double cost = 0;

            if (budget <= 100)
            {
                clas = "Economy class";
                if (season == "Summer")
                {
                    typeVehicle = "Cabrio";
                    cost = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    typeVehicle = "Jeep";
                    cost = budget * 0.65;
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                clas = "Compact class";
                if (season == "Summer")
                {
                    typeVehicle = "Cabrio";
                    cost = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    typeVehicle = "Jeep";
                    cost = budget * 0.8;
                }
            }
            else if (budget > 500)
            {
                clas = "Luxury class";
                typeVehicle = "Jeep";
                cost = budget * 0.9;
            }

            Console.WriteLine($"{clas}");
            Console.WriteLine($"{typeVehicle} - {cost:f2}");
        }
    }
}
