using System;
using System.Reflection.PortableExecutable;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (!ChekThePasswordLength(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!CheckForOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!ChekForAtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (CheckForOnlyLettersAndDigits(password) && ChekForAtLeastTwoDigits(password)&& ChekThePasswordLength(password))
            {
                Console.WriteLine("Password is valid");
            }


        }

        static bool ChekThePasswordLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckForOnlyLettersAndDigits(string password)
        {
            bool cheker = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    cheker = false;
                }
            }

            return cheker;
        }

        static bool ChekForAtLeastTwoDigits(string password)
        {
            int counter = 0;
            bool cheker = false;
            foreach (var charakter in password)
            {
                if (char.IsDigit(charakter))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                cheker = true;
            }

            return cheker;
        }
    }
}
