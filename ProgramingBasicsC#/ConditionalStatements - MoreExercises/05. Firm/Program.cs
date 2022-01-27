using System;

namespace _05._Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            double hoursNeeded = double.Parse(Console.ReadLine());
            double days = double.Parse(Console.ReadLine());
            double employs = double.Parse(Console.ReadLine());

            double daysReal = days - (days * 0.1);
            double workTime = daysReal * 8;
            double overTime = days * (employs * 2);

            double totalTime = Math.Floor(workTime + overTime);

            if (totalTime > hoursNeeded)
            {
                Console.WriteLine($"Yes!{totalTime - hoursNeeded} hours left.");
                
            }
            else
            {
                Console.WriteLine($"Not enough time!{hoursNeeded - totalTime} hours needed.");
                
            }

        }
    }
}
