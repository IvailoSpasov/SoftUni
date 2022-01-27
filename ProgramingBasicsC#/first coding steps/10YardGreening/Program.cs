using System;

namespace _10YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double yardSqMeters = double.Parse(Console.ReadLine());
            double pricePeerSqMeter = 7.61;
            double discount = 0.18;

            double totalYardPrice = yardSqMeters * pricePeerSqMeter;
            double totalDiscount = totalYardPrice * discount;
            double endPrice = totalYardPrice - totalDiscount;

            Console.WriteLine($"The final price is {endPrice} lv.");
            Console.WriteLine($"The discount is {totalDiscount} lv.");
        }
    }
}
