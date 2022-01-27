using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int charity = int.Parse(Console.ReadLine());

            int payCounter = 0;
            double sumCC = 0;
            double counterCC = 0;
            double sumCS = 0;
            double counterCS = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                payCounter++;
                double paySum = double.Parse(input);

                if (payCounter % 2 == 0)
                {
                    if (paySum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCC += paySum;
                        counterCC++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (paySum > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        sumCS += paySum;
                        counterCS++;
                        Console.WriteLine("Product sold!");
                    }
                }
                double avgCC = sumCC / counterCC;
                double avgCS = sumCS / counterCS;
                double totalSum = sumCC + sumCS;
                if (totalSum >= charity)
                {
                    Console.WriteLine($"Average CS: {avgCS:f2}");
                    Console.WriteLine($"Average CC: {avgCC:f2}");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");

            }
        }
    }
}
