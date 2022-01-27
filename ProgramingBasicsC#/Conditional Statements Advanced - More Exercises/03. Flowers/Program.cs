using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrisantemNumber = int.Parse(Console.ReadLine());
            int roseNumber = int.Parse(Console.ReadLine());
            int tulipNumber = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double chrisantemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    chrisantemumPrice = 2;
                    rosePrice = 4.1;
                    tulipPrice = 2.5;
                    break;
                case "Autumn":
                case "Winter":
                    chrisantemumPrice = 3.75;
                    rosePrice = 4.5;
                    tulipPrice = 4.15;
                    break;
            }
            if (holiday == "Y")
            {
                chrisantemumPrice += chrisantemumPrice * 0.15;
                rosePrice += rosePrice * 0.15;
                tulipPrice += tulipPrice * 0.15;
            }

            double price = (chrisantemNumber * chrisantemumPrice) + (tulipNumber * tulipPrice) + (roseNumber * rosePrice);
            double discount = 0;

            if (tulipNumber > 7 && season == "Spring")
            {
                discount = 0.05;
                price -= price * discount;
            }
            if (roseNumber >= 10 && season == "Winter")
            {
                discount = 0.1;
                price -= price * discount;
            }
            if (roseNumber + tulipNumber + chrisantemNumber > 20)
            {
                discount = 0.2;
                price -= price * discount;
            }

            Console.WriteLine($"{price +2:f2}");
        }
    }
}
