using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            double kgVegetables = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            Console.WriteLine($"{((vegetablesPrice * kgVegetables) + (fruitsPrice * kgFruits)) / 1.94:F2}");


        }
    }
}
