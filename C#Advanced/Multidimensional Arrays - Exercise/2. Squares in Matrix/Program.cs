using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowsArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsArray[col];
                }
            }

            int equalSquares = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        char currChar = matrix[row, col];
                        if (currChar == matrix[row, col] && currChar == matrix[row, col + 1] && currChar == matrix[row + 1, col] && currChar == matrix[row + 1, col + 1])
                        {
                            equalSquares++;
                        }
                    }
                }
            }

            Console.WriteLine(equalSquares);
        }
    }
}
