using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNames = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            MatchCollection matchedNames = Regex.Matches(inputNames, regex);
            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value+" ");
            }
        }
    }
}
