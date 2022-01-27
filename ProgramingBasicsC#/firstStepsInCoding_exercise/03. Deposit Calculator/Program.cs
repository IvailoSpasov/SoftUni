using System;

namespace _03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSume = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double glp = double.Parse(Console.ReadLine()) / 100;

            double interest = depositSume * glp;
            double iterestPerMonth = interest / 12;
            double totalSume = depositSume + (depositTerm * iterestPerMonth);

            Console.WriteLine(totalSume);
        }
    }
}
