using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
            while (input[0]!= "Revision")
            {
                string shopName = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName,new Dictionary<string, double>());
                }
                shops[shopName].Add(product,price);
                input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
