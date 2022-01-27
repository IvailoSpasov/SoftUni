using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double pricePerFlower = 0;

            switch (typeFlowers)
            {
                case "Roses":
                    pricePerFlower = 5;
                    break;
                case "Dahlias":
                    pricePerFlower = 3.80;
                    break;
                case "Tulips":
                    pricePerFlower = 2.80;
                    break;
                case "Narcissus":
                    pricePerFlower = 3;
                    break;
                case "Gladiolus":
                    pricePerFlower = 2.50;
                    break;
            }

            double totalPrice = pricePerFlower * numberFlowers;

            if (typeFlowers == "Roses" && numberFlowers > 80)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (typeFlowers == "Dahlias" && numberFlowers > 90)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeFlowers == "Tulips" && numberFlowers > 80)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeFlowers == "Narcissus" && numberFlowers < 120)
            {
                totalPrice += totalPrice * 0.15;
            }
            else if (typeFlowers == "Gladiolus" &&  numberFlowers < 80)
            {
                totalPrice += totalPrice * 0.20;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} and {budget - totalPrice:f2} leva left.");
              
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
