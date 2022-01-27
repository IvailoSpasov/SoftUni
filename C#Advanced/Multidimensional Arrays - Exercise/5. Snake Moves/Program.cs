using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            char[,] matrix = new char[rows, cols];
            string input = Console.ReadLine();
            Queue<char> queue = new Queue<char>(input);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        char temp = queue.Dequeue();
                        queue.Enqueue(temp);
                        matrix[row, j] = temp;
                    }
                }
                else
                {
                    for (int i = matrix.GetLength(1) - 1; i >= 0; i--)
                    {
                        char temp = queue.Dequeue();
                        queue.Enqueue(temp);
                        matrix[row, i] = temp;
                    }
                }
            }

            for (int rowIndex = 0; rowIndex < matrix.GetLength(0); rowIndex++)
            {
                for (int coIndex = 0; coIndex < matrix.GetLength(1); coIndex++)
                {
                    Console.Write(matrix[rowIndex,coIndex]);
                }

                Console.WriteLine();
            }
        }
    }
}
