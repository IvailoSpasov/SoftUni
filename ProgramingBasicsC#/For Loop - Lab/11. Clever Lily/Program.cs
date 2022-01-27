using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerMaschine = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int toyCounter = 0;
            double savedMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += ((i / 2) * 10) - 1;
                }
                else
                {
                    toyCounter++;
                }
            }

            double totalSsaved = savedMoney + (toyCounter * toyPrice);

            if (totalSsaved >= washerMaschine)
            {
                Console.WriteLine($"Yes! {totalSsaved - washerMaschine:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washerMaschine - totalSsaved:f2}");
            }
        }
    }
}
