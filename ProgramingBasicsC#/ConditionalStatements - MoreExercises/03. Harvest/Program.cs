using System;

namespace _03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardSqmeters = int.Parse(Console.ReadLine());
            double grapeForeOneSqMeter = double.Parse(Console.ReadLine());
            int neededLitersVine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double vinequantity = (vineyardSqmeters * grapeForeOneSqMeter) * 0.4;
            double vineProduced = vinequantity / 2.5;

            if (vineProduced < neededLitersVine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersVine - vineProduced)} liters wine needed.");
            }
            else if (vineProduced >= neededLitersVine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(vineProduced)} liters.");
                Console.WriteLine($"{Math.Ceiling(vineProduced - neededLitersVine)} liters left -> {Math.Ceiling((vineProduced - neededLitersVine) / numberOfWorkers)} liters per person.");
                
                
            }
        }
    }
}
