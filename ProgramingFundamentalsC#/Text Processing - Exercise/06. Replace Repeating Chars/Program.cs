using System;
using System.Reflection;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder text = new StringBuilder(input);
            for (int i = 0; i < text.Length-1; i++)
            {
                if (text[i] == text[i + 1])
                {
                    text.Remove(i, 1);
                    i--;
                }

            }

            Console.WriteLine(text);
        }
    }
}
