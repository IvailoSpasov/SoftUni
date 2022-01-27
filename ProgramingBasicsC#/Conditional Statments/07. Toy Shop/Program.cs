using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzlesNumber = int.Parse(Console.ReadLine());
            int dollsNumber = int.Parse(Console.ReadLine());
            int tedyBearNumber = int.Parse(Console.ReadLine());
            int minionsNumber = int.Parse(Console.ReadLine());
            int trucksNumber = int.Parse(Console.ReadLine());

            double totalNumberOfToys = puzzlesNumber + dollsNumber + tedyBearNumber + minionsNumber + trucksNumber;

            double puzzlesPrice = puzzlesNumber * 2.6;
            double dollsPrice = dollsNumber * 3;
            double tedyBearPrice = tedyBearNumber * 4.1;
            double minionsPrice = minionsNumber * 8.2;
            double trucksPrice = trucksNumber * 2;

            double totalPrice = puzzlesPrice + dollsPrice + tedyBearPrice + minionsPrice + trucksPrice;
            double discount = 0;
            if (totalNumberOfToys >= 50)
            {
                discount = totalPrice * 0.25;
            }
            

            double Profit = totalPrice - discount ;
            double totalProfit = Profit - (Profit * 0.1);

            if (totalProfit >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalProfit - excursionPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalProfit - excursionPrice):F2} lv needed.");
            }

        }
    }
}
