using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsAndCols, rowsAndCols];
            for (int rows = 0; rows < rowsAndCols; rows++)
            {
                int[] rowNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int cols = 0; cols < rowsAndCols; cols++)
                {
                    matrix[rows, cols] = rowNumbers[cols];
                }
            }

            string[] input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                int[] splited = input[i].Split(",").Select(int.Parse).ToArray();
                int bombRow = splited[0];
                int bombCol = splited[1];
                int bombRowFinal = bombRow + 1;
                int bombColFinal = bombCol + 1;
                int bombRowStart = bombRow - 1;
                int bombColStart = bombCol - 1;
                if (bombRowStart < 0)
                {
                    bombRowStart = 0;
                }

                if (bombColStart < 0)
                {
                    bombColStart = 0;
                }

                if (bombRowFinal >= rowsAndCols)
                {
                    bombRowFinal = rowsAndCols - 1;
                }

                if (bombColFinal >= rowsAndCols)
                {
                    bombColFinal = rowsAndCols - 1;
                }

                int bomb = matrix[bombRow, bombCol];
                for (int j = bombRowStart; j <= bombRowFinal; j++)
                {
                    for (int k = bombColStart; k <= bombColFinal; k++)
                    {
                        if (matrix[j, k] > 0)
                        {
                            matrix[j, k] -= bomb;
                        }
                    }
                }
            }

            int sum = 0;
            int aliveCells = 0;
            foreach (var cell in matrix)
            {
                if (cell > 0)
                {
                    aliveCells++;
                    sum += cell;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int rowIndex = 0; rowIndex < rowsAndCols; rowIndex++)
            {
                for (int coIndex = 0; coIndex < rowsAndCols; coIndex++)
                {
                    Console.Write(matrix[rowIndex, coIndex] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
