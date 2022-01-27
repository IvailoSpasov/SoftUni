using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int charityDays = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int panCakes = int.Parse(Console.ReadLine());

            int cacesSumPerDay = cakes * 45;
            double wafflesSumPerDay = waffles * 5.8;
            double panCakesSumPerDay = panCakes * 3.2;

            double sumPerDayTotal = (cacesSumPerDay + wafflesSumPerDay + panCakesSumPerDay) * confectioners;
            double sumTotal = sumPerDayTotal * charityDays;
            double expenses = sumTotal / 8;
            double totalCharity = sumTotal - expenses;

            Console.WriteLine(totalCharity);
        }
    }
}
