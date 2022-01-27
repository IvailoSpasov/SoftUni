using System;

namespace _05._Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string money = Console.ReadLine();
            double sum = 0;
            while (true)
            {
                if (money == "NoMoreMoney")
                {
                    break;
                }
                double input = double.Parse(money);

                if (input < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else if (input >= 0)
                {
                    Console.WriteLine($"Increase: {input:f2}");
                    sum += input;
                    money = Console.ReadLine();
                }
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
