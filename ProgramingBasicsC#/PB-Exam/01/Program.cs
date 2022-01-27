using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int transportTickets = int.Parse(Console.ReadLine());
            int museumTickets = int.Parse(Console.ReadLine());

            double nightsSum = nights * 20;
            double transportTicketSum = transportTickets * 1.6;
            double museumTicketsSum = museumTickets * 6;

            double sumPerPerson = nightsSum + transportTicketSum + museumTicketsSum;
            double groupSum = sumPerPerson * people;

            double finalSum = groupSum + (groupSum * 0.25);

            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
