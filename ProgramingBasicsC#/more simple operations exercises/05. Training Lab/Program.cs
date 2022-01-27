using System;

namespace _05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double oplacesInW = w % 1.2;
            double oplacesInH = (h - 1) % 0.7;

            double placesInW = (w - oplacesInW) / 1.2;
            double placesInH = ((h - 1) - oplacesInH) / 0.7;

            Console.WriteLine((placesInH * placesInW) - 3);
        }
    }
}
