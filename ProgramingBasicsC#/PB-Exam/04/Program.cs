using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double firsDayKm = double.Parse(Console.ReadLine());

            double kilometers = 1000;
            kilometers -= firsDayKm;


            for (int i = 0; i < days; i++)
            {
                double percent = double.Parse(Console.ReadLine());
                firsDayKm = firsDayKm + (firsDayKm * (percent / 100));
                kilometers -= firsDayKm;

            }
            if (kilometers >= 0 )
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Ceiling(kilometers)} more kilometers");
            }
            else
            {
                Console.WriteLine($"You've done a great job running {Math.Ceiling(Math.Abs(kilometers))} more kilometers!");
            }
        }
    }
}
