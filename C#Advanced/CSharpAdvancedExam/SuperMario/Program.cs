using System;

namespace SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            int marioRow = 0;
            int marioCol = 0;

            for (int i = 0; i < rows; i++)
            {
                string cols = Console.ReadLine();
                matrix[i] = new char[cols.Length];
                for (int j = 0; j < cols.Length; j++)
                {
                    matrix[i][j] = cols[j];
                    if (matrix[i][j] == 'M')
                    {
                        marioRow = i;
                        marioCol = j;
                    }
                }
            }

            string[] input = Console.ReadLine().Split();

            while (true)
            {
                string command = input[0];
                int browserRow = int.Parse(input[1]);
                int browserCol = int.Parse(input[2]);

                matrix[browserRow][browserCol] = 'B';
                health--;
                matrix[marioRow][marioCol] = '-';
                if (command == "W" && marioRow - 1 >= 0)
                {
                    marioRow--;
                    if (matrix[marioRow][marioCol] == 'B')
                    {
                        health -= 2;
                    }
                    else if (matrix[marioRow][marioCol] == 'P')
                    {
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                        matrix[marioRow][marioCol] = '-';
                        PrintingMatrix(matrix);
                        return;
                    }
                }
                else if (command == "S" && marioRow + 1 < rows)
                {
                    marioRow++;
                    if (matrix[marioRow][marioCol] == 'B')
                    {
                        health -= 2;
                    }
                    else if (matrix[marioRow][marioCol] == 'P')
                    {
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                        matrix[marioRow][marioCol] = '-';
                        PrintingMatrix(matrix);
                        return;
                    }
                }
                else if (command == "A" && marioCol - 1 >=0)
                {
                    marioCol--;
                    if (matrix[marioRow][marioCol] == 'B')
                    {
                        health -= 2;
                    }
                    else if (matrix[marioRow][marioCol] == 'P')
                    {
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                        matrix[marioRow][marioCol] = '-';
                        PrintingMatrix(matrix);
                        return;
                    }
                }
                else if (command == "D" && marioCol + 1 <matrix[0].Length)
                {
                    marioCol++;
                    if (matrix[marioRow][marioCol] == 'B')
                    {
                        health -= 2;
                    }
                    else if (matrix[marioRow][marioCol] == 'P')
                    {
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {health}");
                        matrix[marioRow][marioCol] = '-';
                        PrintingMatrix(matrix);
                        return;
                    }
                }

                if (health<=0)
                {
                    Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                    matrix[marioRow][marioCol] = 'X';
                    PrintingMatrix(matrix);
                    return;
                }

                matrix[marioRow][marioCol] = 'M';

                input = Console.ReadLine().Split();

            }
        }

        private static void PrintingMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(string.Join("",matrix[i]));
            }
        }
    }
}
