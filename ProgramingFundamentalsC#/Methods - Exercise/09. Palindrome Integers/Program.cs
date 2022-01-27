using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (ChekForPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }

        private static bool ChekForPalindrome(string input)
        {
            bool cheker = input[0] == input[input.Length - 1];

            return cheker;
        }
    }
}
