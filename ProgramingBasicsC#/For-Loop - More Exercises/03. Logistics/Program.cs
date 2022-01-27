using System;

namespace _03._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCargos = int.Parse(Console.ReadLine());

            double microbusCargosWeight = 0;
            double truckCargosWeight = 0;
            double trainCargosWeight = 0;

            for (int i = 0; i < numberOfCargos; i++)
            {
                int weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    microbusCargosWeight += weight;
                }
                else if (weight <= 11)
                {
                    truckCargosWeight += weight;
                }
                else if (weight >= 12)
                {
                    trainCargosWeight += weight;
                }
            }
            double totalWeight = microbusCargosWeight + truckCargosWeight + trainCargosWeight;
            double averageCostPerTon = ((microbusCargosWeight * 200) + (truckCargosWeight * 175) + (trainCargosWeight * 120)) / totalWeight;
            double microbusPercent = microbusCargosWeight / totalWeight * 100;
            double truckPercent = truckCargosWeight / totalWeight * 100;
            double trainPercent = trainCargosWeight / totalWeight * 100;

            Console.WriteLine($"{averageCostPerTon:f2}");
            Console.WriteLine($"{microbusPercent:f2}%");
            Console.WriteLine($"{truckPercent:f2}%");
            Console.WriteLine($"{trainPercent:f2}%");
        }
    }
}
