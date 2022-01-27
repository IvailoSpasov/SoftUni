using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,] square = new int[rowsAndCols, rowsAndCols];

            for (int row = 0; row < square.GetLength(0); row++)
            {
                int[] rows = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < square.GetLength(1); col++)
                {
                    square[row, col] = rows[col];
                }
            }

            int sum = 0;
            for (int i = 0; i < rowsAndCols; i++)
            {
                sum += square[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
