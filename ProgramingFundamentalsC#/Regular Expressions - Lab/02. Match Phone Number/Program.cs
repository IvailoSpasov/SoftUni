using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"[+][359]+( |-)2\1[0-9]{3}\1[0-9]{4}\b";
            MatchCollection matchedPhones = Regex.Matches(input, regex);

            List<string> finalPhones = matchedPhones.Cast<Match>().Select(a => a.Value.Trim()).ToList();
            Console.WriteLine(string.Join(", ",finalPhones));

        }
    }
}
