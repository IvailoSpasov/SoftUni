using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string input = Console.ReadLine();
            int counter = 0;
            while (input != password)
            {
                counter++;

                if (counter >= 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
