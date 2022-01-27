using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static string repeatString(string str, int counter)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                result.Append(str);
            }

            return result.ToString();
        }
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(repeatString(inputString,count));
        }
    }
}
