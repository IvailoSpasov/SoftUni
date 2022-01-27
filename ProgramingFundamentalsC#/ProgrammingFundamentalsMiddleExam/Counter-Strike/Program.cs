using System;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int battleCounter = 0;
            while (input != "End of battle")
            {
                int distance = int.Parse(input);
                if (energy >= distance)
                {
                    battleCounter++;
                    energy -= distance;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battleCounter} won battles and {energy} energy");
                    return;
                }

                if (battleCounter % 3 == 0)
                {
                    energy += battleCounter;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Won battles: {battleCounter}. Energy left: {energy}");
        }
    }
}
