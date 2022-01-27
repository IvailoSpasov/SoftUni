using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaHolidays = int.Parse(Console.ReadLine());
            int mountainHolidays = int.Parse(Console.ReadLine());

            double profit = 0;

            string input = Console.ReadLine();

            while (input != "Stop")
            {

                if (input == "sea")
                {
                    if (seaHolidays == 0)
                    {
                        if (seaHolidays == 0 && mountainHolidays == 0)
                        {
                            Console.WriteLine("Good job! Everything is sold.");
                            break;
                        }
                        input = Console.ReadLine();
                        continue;
                    }
                    profit += 680;
                    seaHolidays -= 1;
                }
                else
                {
                    if (mountainHolidays == 0)
                    {
                        if (seaHolidays == 0 && mountainHolidays == 0)
                        {
                            Console.WriteLine("Good job! Everything is sold.");
                            break;
                        }
                        input = Console.ReadLine();
                        continue;
                    }
                    profit += 499;
                    mountainHolidays -= 1;
                }
                if (seaHolidays == 0 && mountainHolidays == 0)
                {
                    Console.WriteLine("Good job! Everything is sold.");
                    break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
