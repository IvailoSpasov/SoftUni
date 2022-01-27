using System;

namespace _9._Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeYear = Console.ReadLine();
            double holiday = double.Parse(Console.ReadLine());
            double weekendsInHomeTown = double.Parse(Console.ReadLine());

            double gamesInSofia = (48 - weekendsInHomeTown) * 3 / 4;
            double gamesInHolydays = holiday * 2 / 3;

            double leepOrNormal = 0;

            switch (typeYear)
            {
                case "leap":
                    leepOrNormal = 0.15;
                    break;
                case "normal":
                    leepOrNormal = 0;
                    break;
            }

            double totalGames = Math.Floor((weekendsInHomeTown + gamesInSofia + gamesInHolydays) + ((weekendsInHomeTown + gamesInSofia + gamesInHolydays) * leepOrNormal));
            Console.WriteLine($"{totalGames}");

        }
    }
}
