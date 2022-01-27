using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double hHouse = double.Parse(Console.ReadLine());
            double lengthSideWall = double.Parse(Console.ReadLine());
            double hRoof = double.Parse(Console.ReadLine());

            double sFrontWall = (hHouse * hHouse) - (1.2 * 2);
            double SBackWall = hHouse * hHouse;
            double SsideWalls = ((hHouse * lengthSideWall) - (1.5 * 1.5)) * 2;

            double Ssideroofs = (lengthSideWall * hHouse) * 2;
            double sTriangleRoof = (hHouse * hRoof / 2) * 2;

            double greenPaint = sFrontWall + SBackWall + SsideWalls;
            double redPaint = Ssideroofs + sTriangleRoof;

            Console.WriteLine($"{greenPaint / 3.4:F2}");
            Console.WriteLine($"{redPaint / 4.3:F2}");

        }
    }
}
