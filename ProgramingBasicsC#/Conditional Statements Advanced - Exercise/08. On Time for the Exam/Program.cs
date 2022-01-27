using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hOfExam = int.Parse(Console.ReadLine());
            int mOfExam = int.Parse(Console.ReadLine());
            int hOfArrival = int.Parse(Console.ReadLine());
            int mOfArrival = int.Parse(Console.ReadLine());

            int exam = (hOfExam * 60) + mOfExam;
            int arrival = (hOfArrival * 60) + mOfArrival;

            int diff = exam - arrival;

            string isItOnTime = "";

            if (diff < 0)
            {
                isItOnTime = "Late";
            }
            else if (diff <= 30)
            {
                isItOnTime = "On time";
            }
            else if (diff > 30)
            {
                isItOnTime = "Early";
            }

            Console.WriteLine($"{isItOnTime}");

            int hourDif = diff / 60;
            int minuteDif = diff % 60;

            if (diff >= 1 && diff <= 59)
            {
                Console.WriteLine($"{diff} minutes before the start");
            }
            else if (diff > 59)
            {
                Console.WriteLine($"{hourDif}:{minuteDif:D2} hours before the start");
            }
            else if (diff < -59)
            {
                Console.WriteLine($"{Math.Abs(hourDif)}:{Math.Abs(minuteDif):d2} hours after the start");
            }
            else if (diff < 0 && diff >= -59)
            {
                Console.WriteLine($"{Math.Abs(diff)} minutes after the start");
            }
        }
    }
}
