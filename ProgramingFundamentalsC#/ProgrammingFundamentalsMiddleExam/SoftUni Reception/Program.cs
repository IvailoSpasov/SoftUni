using System;

namespace SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine());
            int seconEmployeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());

            int studentPerHour = firstEmployeeEfficiency + seconEmployeeEfficiency + thirdEmployeeEfficiency;
            int hours = 0;
            while (numberOfStudents > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }

                numberOfStudents -= studentPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
