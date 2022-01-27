using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] rowss = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowss[col];
                }
            }

            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "END")
            {
                if (input.Length < 5||input[0]!="swap"||int.Parse(input[1])>=rows|| int.Parse(input[1])<0|| int.Parse(input[2])>=cols|| int.Parse(input[2])<0|| int.Parse(input[3])>=rows|| int.Parse(input[3])<0|| int.Parse(input[4])>=cols|| int.Parse(input[4])<0)
                {
                    Console.WriteLine("Invalid input!");

                }
                else
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);
                    string temp = matrix[row1, col1];
                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = temp;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(matrix[i,j]+" ");
                        }

                        Console.WriteLine();
                    }

                }
                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
