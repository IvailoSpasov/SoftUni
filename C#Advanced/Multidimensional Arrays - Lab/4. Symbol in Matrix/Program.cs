using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            char[,] matrix = new Char[rowsAndCols, rowsAndCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowsChars = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowsChars[col];
                }
            }

            char specialSymbul = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row,col]==specialSymbul)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{specialSymbul} does not occur in the matrix ");
        }
    }
}
