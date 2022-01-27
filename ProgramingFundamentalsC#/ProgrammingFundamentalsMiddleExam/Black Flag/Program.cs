using System;

namespace Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dayliPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;

            for (int day = 1; day <= days; day++)
            {
                totalPlunder += dayliPlunder;
                if (day % 3 == 0)
                {
                    totalPlunder += dayliPlunder * 0.50;
                }

                if (day % 5 == 0)
                {
                    totalPlunder -= totalPlunder * 0.30;
                }

            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                double percentage = totalPlunder / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }
        }
    }
}
