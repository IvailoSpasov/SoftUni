using System;
namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double balance = money;

            string input = Console.ReadLine();

            while (input != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    if (balance >= 39.99)
                    {
                    balance -= 39.99;
                    Console.WriteLine($"Bought {input}");
                    input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else if (input == "CS: OG")
                {
                    if (balance >= 15.99)
                    {
                        balance -= 15.99;
                        Console.WriteLine($"Bought {input}");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else if (input == "Zplinter Zell")
                {
                    if (balance >= 19.99)
                    {
                        balance -= 19.99;
                        Console.WriteLine($"Bought {input}");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else if (input == "Honored 2")
                {
                    if (balance >= 59.99)
                    {
                        balance -= 59.99;
                        Console.WriteLine($"Bought {input}");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else if (input == "RoverWatch")
                {
                    if (balance >= 29.99)
                    {
                        balance -= 29.99;
                        Console.WriteLine($"Bought {input}");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    if (balance >= 39.99)
                    {
                        balance -= 39.99;
                        Console.WriteLine($"Bought {input}");
                        input = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                        input = Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                }
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            double spent = money - balance;
            Console.WriteLine($"Total spent: ${spent:f2}. Remaining: ${balance:f2}");
        }
    }
}
