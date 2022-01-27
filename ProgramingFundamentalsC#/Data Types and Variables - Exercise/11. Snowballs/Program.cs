using System;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            double biggestSnowballValue = double.MinValue;
            double biggestSnowballSnow = double.MinValue;
            double biggestSnowballTime = double.MinValue;
            double biggestSnowballQuality = double.MinValue;




            for (int i = 0; i < numberOfSnowballs; i++)
            {
                double snowballSnow = double.Parse(Console.ReadLine());
                double snowballTime = double.Parse(Console.ReadLine());
                double snowballQuality = double.Parse(Console.ReadLine());

                double curvalue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                if (curvalue > biggestSnowballValue)
                {
                    biggestSnowballValue = curvalue;
                    biggestSnowballQuality = snowballQuality;
                    biggestSnowballSnow = snowballSnow;
                    biggestSnowballTime = snowballTime;
                }

            }
            Console.WriteLine($"{biggestSnowballSnow} : {biggestSnowballTime} = {biggestSnowballValue} ({biggestSnowballQuality})");
        }
    }
}
