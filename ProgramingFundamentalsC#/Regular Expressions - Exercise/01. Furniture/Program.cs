using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@">>(?<item>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)", RegexOptions.IgnoreCase);
            List<string> boughtItems = new List<string>();
            double totalPrice = 0;
            while (input!= "Purchase")
            {
                if (regex.IsMatch(input))
                {
                    string item = regex.Match(input).Groups["item"].ToString();
                    double price = double.Parse(regex.Match(input).Groups["price"].ToString());
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].ToString());
                    boughtItems.Add(item);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            boughtItems.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
