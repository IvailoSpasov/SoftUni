using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int normForPlay = 30000;
            int PlayInFreeDays = freeDays * 127;
            int PlayInBussyDays = (365 - freeDays) * 63;
            int totalPlayMinutes = PlayInBussyDays + PlayInFreeDays;

            if (totalPlayMinutes > normForPlay)
            {
                int diference = totalPlayMinutes - normForPlay;
                int hourDiff = diference / 60;
                int minDiff = diference % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hourDiff} hours and {minDiff} minutes more for play");

            }
            else if (totalPlayMinutes < normForPlay)
            {
                int diference = normForPlay - totalPlayMinutes;
                int hourDiff = diference / 60;
                int minDiff = diference % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hourDiff} hours and {minDiff} minutes less for play");
            }
        }
    }
}
