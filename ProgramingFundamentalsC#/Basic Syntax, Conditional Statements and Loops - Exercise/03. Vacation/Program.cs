using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double pricePerNight = 0;
            double discount = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    pricePerNight = 8.45;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 9.80;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 10.46;
                    price = pricePerNight * peopleNumber;
                }
                if (peopleNumber >= 30)
                {
                    discount = price * 0.15;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    pricePerNight = 10.90;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 15.60;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 16;
                    price = pricePerNight * peopleNumber;
                }
                if (peopleNumber >= 100)
                {
                    discount = pricePerNight * 10;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerNight = 15;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Saturday")
                {
                    pricePerNight = 20;
                    price = pricePerNight * peopleNumber;
                }
                else if (day == "Sunday")
                {
                    pricePerNight = 22.50;
                    price = pricePerNight * peopleNumber;
                }
                if (peopleNumber >= 10 && peopleNumber <= 20)
                {
                    discount = price * 0.05;
                }
            }
            Console.WriteLine($"Total price: {(price - discount):f2}");

        }
    }
}
