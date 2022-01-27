using System;

namespace _07.Working_Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            string operOrClosed = "";

            if (hour <= 18 && hour >= 10 && day !="Sunday")
            {
                operOrClosed = "open";
            }
            else
            {
                operOrClosed = "closed";
            }

            Console.WriteLine($"{operOrClosed}");
        }
    }
}
