using System;

namespace _06._Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double elektricityTotal = 0;
            double waterTotal = 0;
            double internetTotal = 0;
            double otherTotal = 0;


            for (int i = 0; i < months; i++)
            {
                double elektricityBill = double.Parse(Console.ReadLine());

                elektricityTotal += elektricityBill;
                waterTotal += 20;
                internetTotal += 15;
                otherTotal += (elektricityBill + 20 + 15) + ((elektricityBill + 20 + 15) * 0.2);
            }
            double average = (elektricityTotal + waterTotal + internetTotal + otherTotal) / months;

            Console.WriteLine($"Electricity: {elektricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTotal:f2} lv");
            Console.WriteLine($"Internet: {internetTotal:f2} lv");
            Console.WriteLine($"Other: {otherTotal:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
