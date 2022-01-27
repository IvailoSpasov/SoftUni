using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encryptedText = new StringBuilder();
            foreach (var letter in text)
            {
                char newLetter = (char) (letter + 3);
                encryptedText.Append(newLetter);
            }

            Console.WriteLine(encryptedText);
        }
    }
}
