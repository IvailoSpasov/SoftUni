using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<Name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>[0-9]+)\|[^|$%.]*?(?<price>\d+[.]?\d+)?\$");
            string input = Console.ReadLine();
            double income = 0;
            while (input != "end of shift")
            {
                if (regex.IsMatch(input))
                {
                    double currTotal = 0;
                    string name = regex.Match(input).Groups["Name"].ToString();
                    string product = regex.Match(input).Groups["product"].ToString();
                    double price = double.Parse(regex.Match(input).Groups["price"].ToString());
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].ToString());
                    currTotal = price * quantity;
                    income += currTotal;
                    Console.WriteLine($"{name}: {product} - {currTotal:f2}");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
