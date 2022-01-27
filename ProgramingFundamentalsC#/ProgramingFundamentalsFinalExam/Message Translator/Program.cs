using System;
using System.Text.RegularExpressions;

namespace Message_Translator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Regex regex = new Regex(@"!(?<command>[A-Z][a-z]{2,})!:\[(?<string>[A-Za-z]{8,})\]");
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    string message = regex.Match(input).Groups["string"].ToString();
                    string command = regex.Match(input).Groups["command"].ToString();
                    string encryptedMessage = string.Empty;
                    for (int j = 0; j < message.Length; j++)
                    {
                        int currLetter = message[j];
                        encryptedMessage += $" {currLetter.ToString()}";
                    }

                    Console.WriteLine($"{command}:{encryptedMessage}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
