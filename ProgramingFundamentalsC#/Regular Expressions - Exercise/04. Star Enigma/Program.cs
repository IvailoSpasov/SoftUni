using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] cryptedMessages = new string[n];
            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                cryptedMessages[i] = message;
            }

            Regex matchSTAR = new Regex(@"[STARstar]");
            for (int i = 0; i < n; i++)
            {
                string currMessage = string.Empty;
                MatchCollection matches = matchSTAR.Matches(cryptedMessages[i]);
                int index = matches.Count;
                foreach (var character in cryptedMessages[i])
                {
                    currMessage += (char)(character - index);
                }

                cryptedMessages[i] = currMessage;
            }
            Regex regex = new Regex(@"@(?<name>[A-Z][a-z]+)[^@\-!:>]*?:[0-9]+[^@\-!:>]*?!(?<AorD>[AD])![^@\-!:>]*?->[0-9]+");
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            foreach (var message in cryptedMessages)
            {
                if (regex.IsMatch(message))
                {

                    string planet = regex.Match(message).Groups["name"].ToString();
                    string type = regex.Match(message).Groups["AorD"].ToString();
                    if (type == "A")
                    {
                        attacked.Insert(0,planet);
                    }
                    else
                    {
                        destroyed.Insert(0,planet);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (var planet in attacked.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (var planet in destroyed.OrderBy(x=>x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
