using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double rest = double.Parse(Console.ReadLine());
            int coinCounter = 0;
            double restInCoins = rest * 100;
            int intrest = (int)restInCoins;

            if (intrest >= 200)
            {
                coinCounter += intrest / 200;
                intrest %= 200;
            }
            if (intrest >= 100)
            {
                coinCounter += intrest / 100;
                intrest %= 100;
            }
            if (intrest >= 50)
            {
                coinCounter += intrest / 50;
                intrest %= 50;
            }
            if (intrest >= 20)
            {
                coinCounter += intrest / 20;
                intrest %= 20;
            }
            if (intrest >= 10)
            {
                coinCounter += intrest / 10;
                intrest %= 10;
            }
            if (intrest >= 5)
            {
                coinCounter += intrest / 5;
                intrest %= 5;
            }
            if (intrest >= 2)
            {
                coinCounter += intrest / 2;
                intrest %= 2;
            }
            if (intrest >= 1)
            {
                coinCounter += intrest / 1;
                intrest %= 1;
            }

            Console.WriteLine(coinCounter);
        }
    }
}
