using System;

namespace _08._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) / 100;

            double tankVol = length * width * height;
            double totalLiters = tankVol * 0.001;
            double finalLiters = totalLiters - (totalLiters * percent);
            

            Console.WriteLine(finalLiters);

        }
    }
}
