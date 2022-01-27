using System;

namespace Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double attLectures = 0;

            for (int i = 1; i <= students; i++)
            {
                double atendance = int.Parse(Console.ReadLine());
                double currBonus = atendance / lectures * (additionalBonus + 5);
                if (currBonus > totalBonus)
                {
                    totalBonus = currBonus;
                    attLectures = atendance;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Round(totalBonus)}.");
            Console.WriteLine($"The student has attended {attLectures} lectures.");
        }
    }
}
