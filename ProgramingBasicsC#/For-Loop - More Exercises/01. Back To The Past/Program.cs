using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double heritage = double.Parse(Console.ReadLine());
            int yearBack = int.Parse(Console.ReadLine());

            double cost = 0;

            for (int i = 1800; i <= yearBack; i++)
            {
                if (i % 2 == 0)
                {
                    cost += 12000;
                }
                else
                {
                    cost += 12000 + ((i - 1782) * 50);
                }
            }
            if (heritage >= cost)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {heritage - cost:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {cost - heritage:f2} dollars to survive.");
            }
        }
    }
}
