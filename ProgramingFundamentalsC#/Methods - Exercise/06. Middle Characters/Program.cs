using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleCharacter(input);
        }

        private static void PrintMiddleCharacter(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{(char)(input[(input.Length/2)-1])}{(char)(input[input.Length / 2])}");
            }
            else
            {
                Console.WriteLine($"{(char)input[input.Length /2]}");
            }
        }
    }
}
