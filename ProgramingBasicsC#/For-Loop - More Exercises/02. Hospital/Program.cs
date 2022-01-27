using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int numberOfDoctors = 7;
            int servd = 0;
            int unServd = 0;

            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && servd < unServd)
                {
                    numberOfDoctors++;

                }
                if (patients >= numberOfDoctors)
                {
                    servd += numberOfDoctors;
                    unServd += patients - numberOfDoctors;
                }
                else
                {
                    servd += patients;
                }
                
                
            }
            Console.WriteLine($"Treated patients: {servd}.");
            Console.WriteLine($"Untreated patients: {unServd}.");
        }
    }
}
