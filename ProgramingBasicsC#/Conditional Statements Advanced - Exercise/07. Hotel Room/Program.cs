using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPricePerNight = 0;
            double apartmentPricePerNight = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPricePerNight = 50;
                    apartmentPricePerNight = 65;
                    break;
                case "June":
                case "September":
                    studioPricePerNight = 75.20;
                    apartmentPricePerNight = 68.70;
                    break;
                case "July":
                case "August":
                    studioPricePerNight = 76;
                    apartmentPricePerNight = 77;
                    break;
            }
            double apartmentDiscount = 0;

            if (nights > 14)
            {
                apartmentDiscount = 0.1;
            }

            double studioDiscount = 0;

            if ((month == "May" || month == "October") && nights > 14)
            {
                studioDiscount = 0.3;
            }
            else if ((month == "May" || month == "October") && nights > 7)
            {
                studioDiscount = 0.05;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                studioDiscount = 0.2;
            }
            double totalApartmentPrice = (apartmentPricePerNight * nights) - ((apartmentPricePerNight * nights) * apartmentDiscount);
            double totalStudioPrice = (studioPricePerNight * nights) - ((studioPricePerNight * nights) * studioDiscount);

            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
