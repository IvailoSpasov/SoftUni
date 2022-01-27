using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double reward = 0;

            if (place == "Bulgaria")
            {
                reward = points * numberOfDancers;
                if (season == "summer")
                {
                    reward -= reward * 0.05;
                }
                else
                {
                    reward -= reward * 0.08;
                }
            }
            else
            {
                reward = (numberOfDancers * points) + ((numberOfDancers * points) * 0.5);
                if (season == "summer")
                {
                    reward -= reward * 0.1;
                }
                else
                {
                    reward -= reward * 0.15;
                }
            }

            double charity = reward * 0.75;

            double sumPerPerson = (reward - charity) / numberOfDancers;

            Console.WriteLine($"Charity - {charity:f2}");
            Console.WriteLine($"Money per dancer - {sumPerPerson:f2}");


        }
    }
}
