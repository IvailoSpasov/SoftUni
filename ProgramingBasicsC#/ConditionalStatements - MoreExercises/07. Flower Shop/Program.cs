using System;

namespace _07._Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnoli = int.Parse(Console.ReadLine());
            int zumbul = int.Parse(Console.ReadLine());
            int rouse = int.Parse(Console.ReadLine());
            int caktus = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double profit = (magnoli * 3.25) + (zumbul * 4) + (rouse * 3.5) + (caktus * 8);
            double totalprofit = profit - (profit * 0.05);

            if (totalprofit >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalprofit - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - totalprofit)} leva.");
                
            }
        }
    }
}
