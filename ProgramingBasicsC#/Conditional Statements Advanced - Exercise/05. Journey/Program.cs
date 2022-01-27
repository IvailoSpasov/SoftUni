using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double cost = 0;
            string destination = "";
            string campOrhotel = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        campOrhotel = "Camp";
                        cost = budget * 0.3;
                        break;
                    case "winter":
                        campOrhotel = "Hotel";
                        cost = budget * 0.7;
                        break;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        campOrhotel = "Camp";
                        cost = budget * 0.4;
                        break;
                    case "winter":
                        cost = budget * 0.8;
                        campOrhotel = "Hotel";
                        break;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                cost = budget * 0.9;
                campOrhotel = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campOrhotel} - {cost:f2}");

        }
    }
}
