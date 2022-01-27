using System;

namespace _01._Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoritBook = Console.ReadLine();
            int bookCounter = 0;
            string curentBook = Console.ReadLine();
            while (curentBook != "No More Books")
            {
                if (curentBook == favoritBook)
                {
                    Console.WriteLine($"You checked {bookCounter} books and found it.");
                    break;
                }
                bookCounter++;
                curentBook = Console.ReadLine();
            }
            if (curentBook == "No More Books")
            {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {bookCounter} books.");

            }
        } 
    }
}
