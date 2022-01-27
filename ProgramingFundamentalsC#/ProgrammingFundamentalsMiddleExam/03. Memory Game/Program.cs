using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();
            string[] input = Console.ReadLine().Split().ToArray();
            int moves = 0;

            while (input[0] != "end")
            {
                moves++;
                int indexOne = int.Parse(input[0]);
                int indexTwo = int.Parse(input[1]);
                if (indexOne == indexTwo || indexOne < 0 || indexOne > numbers.Count - 1 || indexTwo > numbers.Count - 1 || indexTwo < 0)
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count / 2), $"-{moves}a");
                    numbers.Insert((numbers.Count / 2), $"-{moves}a");
                }
                else if (numbers[indexOne] == numbers[indexTwo])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {numbers[indexOne]}!");
                    if (indexOne < indexTwo)
                    {
                        numbers.RemoveAt(indexTwo);
                        numbers.RemoveAt(indexOne);
                    }
                    else
                    {
                        numbers.RemoveAt(indexOne);
                        numbers.RemoveAt(indexTwo);
                    }

                }
                else if (numbers[indexTwo] != numbers[indexOne])
                {
                    Console.WriteLine("Try again!");
                }

                if (numbers.Count <= 1)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }

                input = Console.ReadLine().Split().ToArray();

            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
