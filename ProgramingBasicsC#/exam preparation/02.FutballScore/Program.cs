using System;

namespace _02.FutballScore
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatch = Console.ReadLine();
            string secondMatch = Console.ReadLine();
            string thirdMatch = Console.ReadLine();

            int wins = 0;
            int losses = 0;
            int draws = 0;

            if (firstMatch[0] > firstMatch[2])
            {
                wins++;
            }
            else if (firstMatch[0] < firstMatch[2])
            {
                losses++;
            }
            else
            {
                draws++;
            }
            if (secondMatch[0] > secondMatch[2])
            {
                wins++;
            }
            else if (secondMatch[0] < secondMatch[2])
            {
                losses++;
            }
            else
            {
                draws++;
            }
            if (thirdMatch[0] > thirdMatch[2])
            {
                wins++;
            }
            else if (thirdMatch[0] < thirdMatch[2])
            {
                losses++;
            }
            else
            {
                draws++;
            }
            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {losses} games.");
            Console.WriteLine($" Drawn games: {draws}");
        }
    }
}
