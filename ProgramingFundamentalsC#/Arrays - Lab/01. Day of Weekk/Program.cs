using System;

namespace _01._Day_of_Weekk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new string[7]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int input = int.Parse(Console.ReadLine());
            if (input >=1 && input <=7)
            {
                Console.WriteLine(dayOfWeek[input-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }

        }
    }
}
