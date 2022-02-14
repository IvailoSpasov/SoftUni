using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rows, rows];

            int playerRow = 0;
            int playerCol = 0;

            for (int i = 0; i < rows; i++)
            {
                string cols = Console.ReadLine();
                for (int j = 0; j < rows; j++)
                {
                    matrix[i, j] = cols[j];
                    if (matrix[i, j] == 'f')
                    {
                        playerCol = j;
                        playerRow = i;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                string action = Console.ReadLine();
                if (action == "up")
                {
                    if (playerRow - 1 >= 0)
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerRow--;
                        if (matrix[playerRow,playerCol]=='B')
                        {
                            if (playerRow-1>=0)
                            {
                                playerRow--;
                                if (matrix[playerRow,playerCol]=='F')
                                {
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, playerCol] = 'f';
                                    PrintingMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[playerRow, playerCol] = 'f';
                                }
                            }
                            else
                            {
                                playerRow = rows - 1;
                                matrix[playerRow, playerCol] = 'f';
                            }
                        }
                        else if (matrix[playerRow,playerCol]=='T')
                        {
                            playerRow++;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow,playerCol]=='F')
                        {
                            Console.WriteLine("Player won!");
                            matrix[playerRow, playerCol] = 'f';
                            PrintingMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerRow = rows - 1;
                        matrix[playerRow, playerCol] = 'f';
                    }
                }
                else if (action=="down")
                {
                    if (playerRow + 1 < rows)
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerRow++;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerRow + 1 <rows)
                            {
                                playerRow++;
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, playerCol] = 'f';
                                    PrintingMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[playerRow, playerCol] = 'f';
                                }
                            }
                            else
                            {
                                playerRow = rows + 1;
                                matrix[playerRow, playerCol] = 'f';
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerRow--;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            matrix[playerRow, playerCol] = 'f';
                            PrintingMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerRow = 0;
                        matrix[playerRow, playerCol] = 'f';
                    }
                }
                else if (action=="left")
                {
                    if (playerCol - 1 >= 0)
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerCol--;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerCol - 1 >= 0)
                            {
                                playerCol--;
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, playerCol] = 'f';
                                    PrintingMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[playerRow, playerCol] = 'f';
                                }
                            }
                            else
                            {
                                playerCol = rows - 1;
                                matrix[playerRow, playerCol] = 'f';
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol++;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            matrix[playerRow, playerCol] = 'f';
                            PrintingMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerCol = rows - 1;
                        matrix[playerRow, playerCol] = 'f';
                    }
                }
                else
                {
                    if (playerCol + 1 < rows)
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerCol++;
                        if (matrix[playerRow, playerCol] == 'B')
                        {
                            if (playerCol + 1 < rows)
                            {
                                playerCol++;
                                if (matrix[playerRow, playerCol] == 'F')
                                {
                                    Console.WriteLine("Player won!");
                                    matrix[playerRow, playerCol] = 'f';
                                    PrintingMatrix(matrix);
                                    return;
                                }
                                else
                                {
                                    matrix[playerRow, playerCol] = 'f';
                                }
                            }
                            else
                            {
                                playerCol = rows + 1;
                                matrix[playerRow, playerCol] = 'f';
                            }
                        }
                        else if (matrix[playerRow, playerCol] == 'T')
                        {
                            playerCol--;
                            matrix[playerRow, playerCol] = 'f';
                        }
                        else if (matrix[playerRow, playerCol] == 'F')
                        {
                            Console.WriteLine("Player won!");
                            matrix[playerRow, playerCol] = 'f';
                            PrintingMatrix(matrix);
                            return;
                        }
                        else
                        {
                            matrix[playerRow, playerCol] = 'f';
                        }
                    }
                    else
                    {
                        matrix[playerRow, playerCol] = '-';
                        playerCol = 0;
                        matrix[playerRow, playerCol] = 'f';
                    }
                }
            }

            Console.WriteLine("Player lost!");
            PrintingMatrix(matrix);
        }

        private static void PrintingMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }

                Console.WriteLine();
            }
        }
    }
}
