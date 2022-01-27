using System;

namespace _05._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minut = int.Parse(Console.ReadLine());

            int minutesPlusFifty = minut + 15;

            if (minutesPlusFifty > 59)
            {
                hour = hour + 1;
                minutesPlusFifty = minutesPlusFifty - 60;

                if (hour == 24)
                {
                    hour = 0;
                }
            }
            else if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutesPlusFifty:d2}");
        }
    }
}
