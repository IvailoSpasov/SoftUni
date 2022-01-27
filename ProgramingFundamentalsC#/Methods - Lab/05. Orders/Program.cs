using System;
using System.Threading.Channels;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            CalculateTheSumOfOrder(product, quantity);
        }

        private static void CalculateTheSumOfOrder(string product, double quantity)
        {
           double price = 0;
            switch (product)
            {
                case "coffee":
                    price = quantity * 1.50;
                    break;
                case "water":
                    price = quantity * 1.00;
                    break;
                case "coke":
                    price = quantity * 1.40;
                    break;
                case "snacks":
                    price = quantity * 2.00;
                    break;

            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
