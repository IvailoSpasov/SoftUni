using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double strawberriesPrice = double.Parse(Console.ReadLine());
            double kgBananas = double.Parse(Console.ReadLine());
            double kgOranges = double.Parse(Console.ReadLine());
            double kgRaspberries = double.Parse(Console.ReadLine());
            double kgStrawberries = double.Parse(Console.ReadLine());

            double sumStrawbarries = kgStrawberries * strawberriesPrice;
            double sumRaspberries = kgRaspberries * (strawberriesPrice / 2);
            double sumBananas = kgBananas * ((strawberriesPrice / 2) - (0.8 * (strawberriesPrice / 2)));
            double sumOranges = kgOranges * ((strawberriesPrice / 2) - (0.4 * (strawberriesPrice / 2)));

            double totalSum = sumOranges + sumBananas + sumRaspberries + sumStrawbarries;
            Console.WriteLine($"{totalSum:F2}");



        }
    }
}
