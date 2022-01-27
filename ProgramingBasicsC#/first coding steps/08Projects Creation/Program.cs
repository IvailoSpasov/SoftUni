using System;

namespace _08Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projectCount = int.Parse(Console.ReadLine());

            int hoursPerProject = 3;
            int totalProjectHours = projectCount * hoursPerProject;

            Console.WriteLine($"The architect {architectName} will need {totalProjectHours} hours to complete {projectCount} project/s.");


        }
    }
}
