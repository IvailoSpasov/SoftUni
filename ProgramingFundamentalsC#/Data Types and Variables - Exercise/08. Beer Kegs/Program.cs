using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());

            double volumeOfTheBiggestKeg = double.MinValue;
            string nameOfTheBiggestKeg = string.Empty;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * (radius * radius) * height;

                if (volume > volumeOfTheBiggestKeg)
                {
                    volumeOfTheBiggestKeg = volume;
                    nameOfTheBiggestKeg = name;
                }
            }
            Console.WriteLine(nameOfTheBiggestKeg);
        }
    }
}
