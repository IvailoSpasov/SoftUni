using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weather = double.Parse(Console.ReadLine());

            if (weather > 35)
            {
                Console.WriteLine("unknown");
            }
            else if (weather < 5)
            {
                Console.WriteLine("unknown");
            }
            else if (weather >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if (weather >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (weather >= 15)
            {
                Console.WriteLine("Mild");
            }
            else if (weather >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (weather >= 5)
            {
                Console.WriteLine("Cold");
            }
        }
    }
}
