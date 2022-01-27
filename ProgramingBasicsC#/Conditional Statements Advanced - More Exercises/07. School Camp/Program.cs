using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string typeOfGroup = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfnights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;

            if (typeOfGroup == "mixed")
            {
                if (season == "Winter")
                {
                    pricePerNight = 10;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 9.5;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 20;
                }
            }
            else if (typeOfGroup == "boys" || typeOfGroup == "girls")
            {
                if (season == "Winter")
                {
                    pricePerNight = 9.60;
                }
                else if (season == "Spring")
                {
                    pricePerNight = 7.20;
                }
                else if (season == "Summer")
                {
                    pricePerNight = 15;
                }
            }

            double discount = 0;

            if (numberOfStudents >= 50)
            {
                discount = 0.5;
            }
            else if (numberOfStudents >= 20 && numberOfStudents < 50)
            {
                discount = 0.15;
            }
            else if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                discount = 0.05;
            }

            string sport = "";

            if (typeOfGroup == "girls")
            {
                switch (season)
                {
                    case "Winter":
                        sport = "Gymnastics";
                        break;
                    case "Spring":
                        sport = "Athletics";
                        break;
                    case "Summer":
                        sport = "Volleyball";
                        break;
                }
            }
            else if (typeOfGroup == "boys")
            {
                switch (season)
                {
                    case "Winter":
                        sport = "Judo";
                        break;
                    case "Spring":
                        sport = "Tennis";
                        break;
                    case "Summer":
                        sport = "Football";
                        break;
                }
            }
            else if (typeOfGroup == "mixed")
            {
                switch (season)
                {
                    case "Winter":
                        sport = "Ski";
                        break;
                    case "Spring":
                        sport = "Cycling";
                        break;
                    case "Summer":
                        sport = "Swimming";
                        break;
                }
            }

            double price = numberOfnights * numberOfStudents * pricePerNight;
            double priceAfterDiscount = price - (price * discount);

            Console.WriteLine($"{sport} {priceAfterDiscount:f2} lv.");

        }
    }
}
