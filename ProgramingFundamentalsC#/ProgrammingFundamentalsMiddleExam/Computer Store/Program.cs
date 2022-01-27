using System;

namespace Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            decimal priceWhitoutTaxes = 0;
            while (input != "special" && input != "regular")
            {
                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                }
                else
                {
                    priceWhitoutTaxes += (decimal)price;
                    input = Console.ReadLine();
                }
            }

            if (priceWhitoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal taxes = priceWhitoutTaxes * (decimal)0.20;
            decimal totalPrice = priceWhitoutTaxes + taxes;

            if (input == "special")
            {
                totalPrice -= totalPrice * (decimal) 0.10;
            }

            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {priceWhitoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPrice:f2}$");
        }
    }
}
