using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int rowsAndCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsAndCols, rowsAndCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[0][col];
                }
            }

            int removedKnights = 0;
            while (true)
            {
                int maxAttack = 0;
                int knightRow = 0;
                int knightCol = 0;
                for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
                {
                    for (int colIndex = 0; colIndex < matrix.GetLength(1); colIndex++)
                    {
                        int currAtacks = 0;
                        if (matrix[rowIndex, colIndex] == 'K')
                        {
                            if (IsValidIndex(matrix, rowIndex + 2, colIndex + 1))
                            {
                                if (matrix[rowIndex + 2, colIndex + 1] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex + 2, colIndex - 1))
                            {
                                if (matrix[rowIndex + 2, colIndex - 1] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex - 2, colIndex + 1))
                            {
                                if (matrix[rowIndex - 2, colIndex + 1] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex - 2, colIndex - 1))
                            {
                                if (matrix[rowIndex - 2, colIndex - 1] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex - 1, colIndex + 2))
                            {
                                if (matrix[rowIndex - 1, colIndex + 2] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex + 1, colIndex + 2))
                            {
                                if (matrix[rowIndex + 1, colIndex + 2] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex - 1, colIndex - 2))
                            {
                                if (matrix[rowIndex - 1, colIndex - 2] == 'K')
                                {
                                    currAtacks++;
                                }
                            }
                            if (IsValidIndex(matrix, rowIndex + 1, colIndex - 2))
                            {
                                if (matrix[rowIndex + 1, colIndex - 2] == 'K')
                                {
                                    currAtacks++;
                                }
                            }

                            if (currAtacks > maxAttack)
                            {
                                maxAttack = currAtacks;
                                knightRow = rowIndex;
                                knightCol = colIndex;
                            }
                        }
                    }
                }

                if (maxAttack > 0)
                {
                    removedKnights++;
                    matrix[knightRow, knightCol] = '0';
                }
                else
                {
                    Console.WriteLine(removedKnights);
                    return;
                }
            }

        }

        private static bool IsValidIndex(char[,] matrix, int rowIndex, int colIndex)
        {
            if (rowIndex >= 0 && colIndex >= 0 && rowIndex < matrix.GetLength(0) && colIndex < matrix.GetLength(1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
