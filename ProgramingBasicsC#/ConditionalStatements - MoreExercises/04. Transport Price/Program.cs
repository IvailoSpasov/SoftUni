using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            if (kilometers < 20)
            {
                if (dayOrNight == "day")
                {
                    double price = 0.7 + kilometers * 0.79;
                    Console.WriteLine($"{price:F2}");
                }
                else
                {
                    double price = 0.7 + kilometers * 0.90;
                    Console.WriteLine($"{price:F2}");

                }
            }
            else if (kilometers < 100)
            {
                Console.WriteLine($"{(kilometers * 0.09):f2}");
            }
            else if (kilometers > 100)
            {
                Console.WriteLine($"{(kilometers * 0.06):F2}");
            }
        }
    }
}
