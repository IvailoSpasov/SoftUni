using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int course = 1;
            double avgGrade = 0;
            double cutcounter = 0;
            bool hasBeenCut = false;
            while (course <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                avgGrade += grade;
                course++;
                if (grade < 4)
                {
                    cutcounter++;
                    if (cutcounter == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {course - 2} grade");
                        hasBeenCut = true;
                        break;
                    }

                }

            }
            if (!hasBeenCut)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avgGrade / 12:f2}");

            }
        }
    }
}
