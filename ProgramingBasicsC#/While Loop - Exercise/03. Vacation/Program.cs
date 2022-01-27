using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double saveMoney = double.Parse(Console.ReadLine());
            int spendDayCounter = 0;
            int daysCounter = 0;
            

            while (saveMoney < moneyNeeded)
            {
                string action = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                daysCounter++;

                if (action == "spend")
                {
                    spendDayCounter++;
                    saveMoney -= amount;
                    if (saveMoney < 0)
                    {
                        saveMoney = 0;
                    }
                }
                else
                {
                    spendDayCounter = 0;
                    saveMoney += amount;
                }
                if (spendDayCounter == 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine(daysCounter);
                    break;
                }
            }
            if (saveMoney >= moneyNeeded)
            {
            Console.WriteLine($"You saved the money for {daysCounter} days.");

            }
        }
    }
}
