using System;

namespace Conditional_tatments
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            bool isExellentGrade = grade >= 5.5;

            if (isExellentGrade) 
            {
                Console.WriteLine("Excellent!"); 
            }
        }
    }
}
