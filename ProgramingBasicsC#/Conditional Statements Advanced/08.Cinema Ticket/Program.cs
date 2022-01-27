using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheeWeek = Console.ReadLine();

            if (dayOfTheeWeek == "Monday" || dayOfTheeWeek == "Tuesday" || dayOfTheeWeek == "Friday")
            {
                Console.WriteLine(12);
            }
            else if (dayOfTheeWeek == "Wednesday" || dayOfTheeWeek == "Thursday")
            {
                Console.WriteLine(14);
            }
            else if (dayOfTheeWeek == "Saturday" || dayOfTheeWeek == "Sunday")
            {
                Console.WriteLine(16);
            }
        }
    }
}
