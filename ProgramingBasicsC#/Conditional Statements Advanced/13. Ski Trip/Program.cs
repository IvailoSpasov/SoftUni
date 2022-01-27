using System;

namespace _13._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rating = Console.ReadLine();

            int night = days - 1;
            double discount = 0;
            double roomPrice = 0;

            if (roomType == "room for one person")
            {
                roomPrice = 18;
                discount = 0;
            }
            else if (roomType == "apartment")
            {
                roomPrice = 25;

                if (days < 10)
                {
                    discount = 0.3;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.35;
                }
                else if (days > 15)
                {
                    discount = 0.5;
                }
            }
            else if (roomType == "president apartment")
            {
                roomPrice = 35;

                if (days < 10)
                {
                    discount = 0.1;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 0.15;
                }
                else if (days > 15)
                {
                    discount = 0.2;
                }
            }
            double price = (night * roomPrice) - ((night * roomPrice) * discount);

            if (rating == "positive")
            {
                price += price * 0.25;
            }
            else
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
