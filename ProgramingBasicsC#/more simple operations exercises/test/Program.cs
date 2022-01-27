using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            double palamudPrice = (skumriqPrice * 0.6) + skumriqPrice;
            double safridPrice = (cacaPrice * 0.8) + cacaPrice;

            Console.WriteLine($"{(palamudPrice * palamudKg) + (safridKg * safridPrice) + (midiKg * 7.5):F2}") ;

        }
    }
}
