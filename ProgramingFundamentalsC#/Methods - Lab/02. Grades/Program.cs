using System;

namespace _02._Grades
{
    class Program
    {
        static void PrintingGradeWithWords(double grade)
        {
            string gradeInWords = string.Empty;

            if (grade >= 2 && grade <= 2.99)
            {
                gradeInWords = "Fail";
            }
            else if (grade > 2.99 && grade <= 3.49)
            {
                gradeInWords = "Poor";
            }
            else if (grade > 3.49 && grade <= 4.49)
            {
                gradeInWords = "Good";
            }
            else if (grade > 4.49 && grade < 5.49)
            {
                gradeInWords = "Very good";
            }
            else
            {
                gradeInWords = "Excellent";
            }

            Console.WriteLine(gradeInWords);

        }
        static void Main(string[] args)
        {
            PrintingGradeWithWords(double.Parse(Console.ReadLine()));
        }
    }
}
