using System;

namespace Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodKg = Double.Parse(Console.ReadLine());
            double hayKg = Double.Parse(Console.ReadLine());
            double coverKg = Double.Parse(Console.ReadLine());
            double weight = Double.Parse(Console.ReadLine());

            for (int i = 1; i <= 30; i++)
            {
                foodKg -= 0.300;
                if (i % 2 == 0)
                {
                    hayKg -= foodKg * 0.05;
                }

                if (i % 3 == 0)
                {
                    coverKg -= weight / 3;
                }

                if (foodKg <= 0 || hayKg <= 0 || coverKg <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodKg:f2}, Hay: {hayKg:f2}, Cover: {coverKg:f2}.");
        }
    }
}
