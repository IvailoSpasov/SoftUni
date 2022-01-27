using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());

            int chemical = bottles * 750;
            int cicleCounter = 0;
            int dishesCounter = 0;
            int potsCounter = 0;
            string input = Console.ReadLine();

            while (input != "End")
            {
                int dishes = int.Parse(input);
                cicleCounter++;
                if (cicleCounter % 3 == 0)
                {
                    chemical -= dishes * 15;
                    potsCounter += dishes;
                }
                else
                {
                    chemical -= dishes * 5;
                    dishesCounter += dishes;
                }
                if (chemical < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(chemical)} ml. more necessary!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End")
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishesCounter} dishes and {potsCounter} pots were washed.");
                Console.WriteLine($"Leftover detergent {chemical} ml.");
            }

        }
    }
}
