using System;

namespace _01._The_Biscuit_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int biscuitsProducedByCompetingFactory = int.Parse(Console.ReadLine());

            double totalProduction = 0;


            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    totalProduction += Math.Floor((biscuitsPerDay * numberOfWorkers) * 0.75);
                }
                else
                {
                    totalProduction += biscuitsPerDay * numberOfWorkers;
                }
            }

            Console.WriteLine($"You have produced {totalProduction} biscuits for the past month.");
            if (totalProduction > biscuitsProducedByCompetingFactory)
            {
                double diff = totalProduction - biscuitsProducedByCompetingFactory;
                double percentage = (diff / biscuitsProducedByCompetingFactory) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
            else
            {
                double diff = biscuitsProducedByCompetingFactory - totalProduction;
                double percentage = (diff / biscuitsProducedByCompetingFactory) * 100;
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
        }
    }
}
