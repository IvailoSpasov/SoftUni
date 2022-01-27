using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfJuniors = int.Parse(Console.ReadLine());
            int numberOfSeniors = int.Parse(Console.ReadLine());
            string typeOfTrack = Console.ReadLine();

            double chargeJuniors = 0;
            double chargeSeniors = 0;

            switch (typeOfTrack)
            {
                case "trail":
                    chargeJuniors = 5.5;
                    chargeSeniors = 7;
                    break;
                case "cross-country":
                    if (numberOfJuniors + numberOfSeniors >= 50)
                    {
                        chargeJuniors = 8 * 0.75;
                        chargeSeniors = 9.5 * 0.75;
                    }
                    else
                    {
                        chargeJuniors = 8;
                        chargeSeniors = 9.5;
                    }
                    break;
                case "downhill":
                    chargeJuniors = 12.25;
                    chargeSeniors = 13.75;
                    break;
                case "road":
                    chargeJuniors = 20;
                    chargeSeniors = 21.50;
                    break;
            }
            double profit = (numberOfJuniors * chargeJuniors + numberOfSeniors * chargeSeniors) *0.95;

            Console.WriteLine($"{profit:f2}");
        }
    }
}
