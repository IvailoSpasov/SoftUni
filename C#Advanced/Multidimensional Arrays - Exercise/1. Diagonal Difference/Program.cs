using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsAndCols, rowsAndCols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                firstDiagonalSum += matrix[i, i];
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                {
                    secondDiagonalSum += matrix[row, col];
                    row++;
                }
            }

            int absSum = Math.Abs(firstDiagonalSum - secondDiagonalSum);
            Console.WriteLine(absSum);
        }
    }
}
