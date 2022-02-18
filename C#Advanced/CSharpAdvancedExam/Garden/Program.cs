using System;
using System.Collections.Generic;
using System.Linq;

namespace Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] garden = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    garden[i, j] = 0;
                }
            }

            string cordinates = Console.ReadLine();
            List<int[]> fwolers = new List<int[]>();
            while (cordinates != "Bloom Bloom Plow")
            {
                int[] splited = cordinates.Split().Select(int.Parse).ToArray();
                int row = splited[0];
                int col = splited[1];

                if (row >= 0 && row < rows && col >= 0 && col < cols)
                {
                    fwolers.Add(new int[2] { row, col });
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }

                cordinates = Console.ReadLine();
            }

            for (int i = 0; i < fwolers.Count; i++)
            {
                int row = fwolers[i][0];
                int col = fwolers[i][1];
                garden[row, col]++;

                for (int j = 0; j < cols; j++)
                {
                    if (j != col)
                    {
                        garden[row, j]++;
                    }
                }

                for (int k = 0; k < rows; k++)
                {
                    if (k != row)
                    {
                        garden[k, col]++;
                    }
                }
            }

            for (int rowsIndex = 0; rowsIndex < rows; rowsIndex++)
            {
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    Console.Write($"{garden[rowsIndex, colIndex]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
