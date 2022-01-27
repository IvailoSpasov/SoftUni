using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var name in usernames)
            {
                if (name.Length > 3 && name.Length <= 16)
                {
                    bool isNameValid = true;

                    foreach (var letter in name)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '_' || letter == '-'))
                        {
                            isNameValid = false;
                            break;
                        }
                    }

                    if (isNameValid)
                    {
                        Console.WriteLine(name);
                    }

                }
            }
        }
    }
}
