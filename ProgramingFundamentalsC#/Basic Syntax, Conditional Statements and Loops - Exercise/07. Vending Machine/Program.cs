using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double sum = 0;

            while (input != "Start")
            {
                double coins = Convert.ToDouble(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum < 2)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    sum -= 2;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (product == "Water")
                {
                    if (sum < 0.7)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    sum -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (product == "Crisps")
                {
                    if (sum < 1.5)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    sum -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (product == "Soda")
                {
                    if (sum < 0.8)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    sum -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else if (product == "Coke")
                {
                    if (sum < 1)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        product = Console.ReadLine();
                        continue;
                    }
                    sum -= 1.0;
                    Console.WriteLine($"Purchased coke");
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();


            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
