using System;
using System.Text;

namespace The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split("|");
            StringBuilder messege = new StringBuilder(input);

            while (command[0] != "Decode")
            {
                if (command[0] == "Move")
                {
                    int numOfLetters = int.Parse(command[1]);
                    for (int i = 0; i < numOfLetters; i++)
                    {
                        char temp = messege[0];
                        messege.Remove(0, 1);
                        messege.Append(temp);
                    }
                }
                else if (command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    messege.Insert(index, value);
                }
                else if (command[0] == "ChangeAll")
                {
                    string substr = command[1];
                    string valueToReplace = command[2];
                    messege.Replace(substr, valueToReplace);
                }
                command = Console.ReadLine().Split("|");
            }

            Console.WriteLine($"The decrypted message is: {messege}");
        }

    }
}

