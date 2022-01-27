using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            double numberOfPeople = double.Parse(Console.ReadLine());

            double tripCost = 0;

            if (numberOfPeople <= 4)
            {
                tripCost = budget * 0.75;
            }
            else if (numberOfPeople <= 9)
            {
                tripCost = budget * 0.6;
            }
            else if (numberOfPeople <= 24)
            {
                tripCost = budget * 0.5;
            }
            else if (numberOfPeople <= 49)
            {
                tripCost = budget * 0.4;
            }
            else if (numberOfPeople >= 50)
            {
                tripCost = budget * 0.25;
            }

            double ticketCost = 0;

            switch (category)
            {
                case "VIP":
                    ticketCost = numberOfPeople * 499.99;
                    break;
                case "Normal":
                    ticketCost = numberOfPeople * 249.99;
                    break;
            }

            double moneyLeftforTickets = budget - tripCost;

            if (moneyLeftforTickets >= ticketCost)
            {
                Console.WriteLine($"Yes! You have {moneyLeftforTickets - ticketCost:f2} leva left.");
            }
            else if (moneyLeftforTickets < ticketCost)
            {
                Console.WriteLine($"Not enough money! You need {ticketCost - moneyLeftforTickets:f2} leva.");
            }
        }
    }
}
