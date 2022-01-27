using System;

namespace _07._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            double studentTicketCount = 0;
            double standardTicketCount = 0;
            double kidTicketCount = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                double tikerSoldForMovie = 0;
                string ticketsType = Console.ReadLine();
                while (ticketsType != "End")
                {
                    if (ticketsType == "student")
                    {
                        studentTicketCount++;
                    }
                    else if (ticketsType == "standard")
                    {
                        standardTicketCount++;
                    }
                    else if (ticketsType == "kid")
                    {
                        kidTicketCount++;
                    }
                    tikerSoldForMovie++;
                    if (tikerSoldForMovie == availableSeats)
                    {
                        break;
                    }
                    ticketsType = Console.ReadLine();
                }
                double seatsTakenPrecentage = tikerSoldForMovie / availableSeats * 100;
                Console.WriteLine($"{movie} - {seatsTakenPrecentage:f2}% full.");
                movie = Console.ReadLine();

            }

            double totalTickets = standardTicketCount + kidTicketCount + studentTicketCount;
            double standardPercent = standardTicketCount / totalTickets * 100;
            double studentPercent = studentTicketCount / totalTickets * 100;
            double kidsPercent = kidTicketCount / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidsPercent:F2}% kids tickets.");
        }
    }
}
