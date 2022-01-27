using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowsArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsArray[col];
                }
            }
            int maxSum = Int32.MinValue;
            int maxSquareRowIndex = 0;
            int maxSquareColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] +
                                  matrix[row + 1, col + 1];
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            maxSquareRowIndex = row;
                            maxSquareColIndex = col;
                        }

                    }
                }
            }

            for (int row = maxSquareRowIndex; row <= maxSquareRowIndex+1; row++)
            {
                for (int col = maxSquareColIndex; col <= maxSquareColIndex+1; col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
