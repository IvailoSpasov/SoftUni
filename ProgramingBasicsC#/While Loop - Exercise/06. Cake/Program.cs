using System;

namespace _06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double piecesInStok = a * b;

            string input = Console.ReadLine();

            while (input != "STOP")
            {
                double piecesNeeded = double.Parse(input);
                piecesInStok -= piecesNeeded;
                if (piecesInStok <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(piecesInStok)} pieces more.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                Console.WriteLine($"{piecesInStok} pieces are left.");
            }
        }
    }
}
