using System;

namespace Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] commands = Console.ReadLine().Split();
            while (commands[0]!= "Done")
            {
                string cmd = commands[0];
                if (cmd == "TakeOdd")
                {
                    string currPasword = String.Empty;
                    for (int i = 1; i < password.Length; i+=2)
                    {
                        currPasword += password[i];
                    }

                    password = currPasword;
                    Console.WriteLine(password);
                }
                else if (cmd == "Cut")
                {
                    int index = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                else if (cmd == "Substitute")
                {
                    string substr = commands[1];
                    string substitute = commands[2];
                    if (password.Contains(substr))
                    {
                        password = password.Replace(substr, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                commands = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
