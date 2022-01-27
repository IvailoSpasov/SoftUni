using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input[0]!= "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                if (!products.ContainsKey(product))
                {
                    products.Add(product,new List<double>(){price,quantity});
                }
                else
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                input = Console.ReadLine().Split();
            }

            foreach (var product in products)
            {
                double totalPrice = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {totalPrice:f2}");
            }
        }
    }
}
