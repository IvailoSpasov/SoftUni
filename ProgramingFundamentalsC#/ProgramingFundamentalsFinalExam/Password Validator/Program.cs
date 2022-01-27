using System;

namespace Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "Complete")
            {
                string cmd = command[0];
                if (cmd == "Make")
                {
                    string upperOrLower = command[1];
                    int index = int.Parse(command[2]);
                    string letter = password[index].ToString();
                    password = password.Remove(index, 1);
                    if (upperOrLower == "Upper")
                    {
                        letter = letter.ToUpper();
                        password = password.Insert(index, letter);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        letter = letter.ToLower();
                        password = password.Insert(index, letter);
                        Console.WriteLine(password);
                    }
                }
                else if (cmd == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    if (index >= 0 && index < password.Length)
                    {
                        password = password.Insert(index, value);
                        Console.WriteLine(password);
                    }
                }
                else if (cmd == "Replace")
                {
                    char charr = char.Parse(command[1]);
                    int value = int.Parse(command[2]);
                    if (password.Contains(charr))
                    {
                        int newintChar = charr + value;
                        char newChar = (char)newintChar;
                        password = password.Replace(charr, newChar);
                        Console.WriteLine(password);
                    }
                }
                else if (cmd == "Validation")
                {
                    if (password.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 characters long!");
                    }

                    bool isOnliLettersDigitsAnd_ = true;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (!(char.IsLetterOrDigit(password[i]) || password[i] == '_'))
                        {
                            isOnliLettersDigitsAnd_ = false;
                            break;
                        }
                    }

                    if (!isOnliLettersDigitsAnd_)
                    {
                        Console.WriteLine("Password must consist only of letters, digits and _!");
                    }

                    bool thasHaveUperrLetter = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsUpper(password[i]))
                        {
                            thasHaveUperrLetter = true;
                            break;
                        }
                    }

                    if (!thasHaveUperrLetter)
                    {
                        Console.WriteLine("Password must consist at least one uppercase letter!");
                    }
                    bool thasHaveWollerLetter = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsLower(password[i]))
                        {
                            thasHaveWollerLetter = true;
                            break;
                        }
                    }

                    if (!thasHaveWollerLetter)
                    {
                        Console.WriteLine("Password must consist at least one lowercase letter!");
                    }
                    bool thasHaveDigit = false;
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (char.IsDigit(password[i]))
                        {
                            thasHaveDigit = true;
                            break;
                        }
                    }

                    if (!thasHaveDigit)
                    {
                        Console.WriteLine("Password must consist at least one digit!");
                    }
                }
                command = Console.ReadLine().Split();
            }

        }
    }
}
