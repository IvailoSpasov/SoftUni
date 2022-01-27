using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hoursPerBook = pagesInBook / pagesPerHour;
            double hoursPerDay = hoursPerBook / days;

            Console.WriteLine(hoursPerDay);


        }
    }
}
