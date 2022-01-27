using System;

namespace _07._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double totalTime = lenght * timePerMeter;
            double delay = Math.Floor(lenght / 15) * 12.5;
            totalTime += delay;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
        }
    }
}
