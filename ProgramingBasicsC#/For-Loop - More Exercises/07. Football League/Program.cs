using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());

            double sectorAFans = 0;
            double sectorBFans = 0;
            double sectorVFans = 0;
            double sectorGFans = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    sectorAFans++;
                }
                else if (sector == "B")
                {
                    sectorBFans++;
                }
                else if (sector == "V")
                {
                    sectorVFans++;
                }
                else if (sector == "G")
                {
                    sectorGFans++;
                }
            }
            double capacityPercent = (sectorAFans + sectorBFans + sectorGFans + sectorVFans) / capacity * 100;
            double sectorAFansPercent = sectorAFans / fans * 100;
            double sectorBFansPercent = sectorBFans / fans * 100;
            double sectorVFansPercent = sectorVFans / fans * 100;
            double sectorGFansPercent = sectorGFans / fans * 100;

            Console.WriteLine($"{sectorAFansPercent:f2}%");
            Console.WriteLine($"{sectorBFansPercent:f2}%");
            Console.WriteLine($"{sectorVFansPercent:f2}%");
            Console.WriteLine($"{sectorGFansPercent:f2}%");
            Console.WriteLine($"{capacityPercent:f2}%");
        }
    }
}
