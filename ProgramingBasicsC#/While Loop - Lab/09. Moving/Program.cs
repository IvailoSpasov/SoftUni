using System;

namespace _09._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            double shir = double.Parse(Console.ReadLine());
            double dal = double.Parse(Console.ReadLine());
            double vis = double.Parse(Console.ReadLine());

            double HouseCubMeter = shir * dal * vis;
            string input = Console.ReadLine();
            bool hasRoomLeft = true;

            while (input != "Done")
            {
                int boxCount = int.Parse(input);
                HouseCubMeter = HouseCubMeter - boxCount;
                if (HouseCubMeter <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(HouseCubMeter)} Cubic meters more.");
                    hasRoomLeft = false;
                    break;
                }
                input = Console.ReadLine();

            }
            if (hasRoomLeft)
            {
            Console.WriteLine($"{HouseCubMeter} Cubic meters left.");
            }
        }
    }
}
