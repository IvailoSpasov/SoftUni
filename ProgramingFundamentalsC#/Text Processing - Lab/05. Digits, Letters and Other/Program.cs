using System;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (char.IsDigit(currentChar))
                {
                    Console.Write(currentChar);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (char.IsLetter(currentChar))
                {
                    Console.Write(currentChar);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                if (!char.IsLetterOrDigit(currentChar))
                {
                    Console.Write(currentChar);
                }
            }
        }
    }
}
