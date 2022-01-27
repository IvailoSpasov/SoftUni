using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"(^|\s)[A-Za-z0-9][\w\.\-]*[A-Za-z0-9]@[A-Za-z]+([\.\-][A-Za-z]+)+\b");
            MatchCollection match = regex.Matches(input);
            foreach (Match email in match)
            {
                Console.WriteLine(email);
            }
        }
    }
}
