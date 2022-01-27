using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 30;

            if (minute > 59)
            {
                hour += 1;
                minute = minute % 60;
                if (hour > 23)
                {
                    hour = 0;
                }
            }
            Console.WriteLine($"{hour}:{minute:D2}");

        }
    }
}
