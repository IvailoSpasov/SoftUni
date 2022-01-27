using System;

namespace bathroom
{
    class Program
    {
        static void Main(string[] args)
        {
            double wallHeight = double.Parse(Console.ReadLine());
            double wallWidth = double.Parse(Console.ReadLine());
            double price = 10.5;
            double discount = 0.1;

            double bathroomSqMeters = wallHeight * wallWidth;
            double totalPrice = price * bathroomSqMeters;
            double priceDiscount = totalPrice * discount;
            double finalPrice = totalPrice - priceDiscount;

            Console.WriteLine($"The price is {totalPrice} lv.");
            Console.WriteLine($"The price after discount is {finalPrice} lv.");

        }
    }
}
