using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {

            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double moousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= lostGames; i++)
            {

                if (i % 2 == 0)
                {
                    totalPrice += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    totalPrice += moousePrice;
                }
                if (i % 6 == 0)
                {
                    totalPrice += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    totalPrice += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");

        }
    }
}
