using System;
using System.Linq;

namespace Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] beach = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                char[] colsChars = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                beach[i] = new char[colsChars.Length];
                for (int j = 0; j < colsChars.Length; j++)
                {
                    beach[i][j] = colsChars[j];
                }
            }

            int tokens = 0;
            int oponentTokens = 0;

            string[] input = Console.ReadLine().Split();
            while (input[0] != "Gong")
            {
                if (input[0] == "Find")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                    {
                        tokens++;
                        beach[row][col] = '-';
                    }
                }
                else if (input[0] == "Opponent")
                {
                    int row = int.Parse(input[1]);
                    int col = int.Parse(input[2]);
                    string direction = input[3];
                    if (direction == "up")
                    {
                        if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                        {
                            if (beach[row][col] == 'T')
                            {
                                oponentTokens++;
                                beach[row][col] = '-';
                            }

                            for (int i = 1; i < 4; i++)
                            {
                                if (row - i >= 0 && row - i < rows && col >= 0 && col < beach[row - i].Length && beach[row - i][col] == 'T')
                                {
                                    oponentTokens++;
                                    beach[row - i][col] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "down")
                    {
                        if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                        {
                            if (beach[row][col] == 'T')
                            {
                                oponentTokens++;
                                beach[row][col] = '-';
                            }

                            for (int i = 1; i < 4; i++)
                            {
                                if (row + i >= 0 && row + i < rows && col >= 0 && col < beach[row + i].Length && beach[row + i][col] == 'T')
                                {
                                    oponentTokens++;
                                    beach[row + i][col] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "left")
                    {
                        if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                        {
                            if (beach[row][col] == 'T')
                            {
                                oponentTokens++;
                                beach[row][col] = '-';
                            }

                            for (int i = 1; i < 4; i++)
                            {
                                if (row >= 0 && row < rows && col - i >= 0 && col - i < beach[row].Length && beach[row][col - i] == 'T')
                                {
                                    oponentTokens++;
                                    beach[row][col - i] = '-';
                                }
                            }
                        }
                    }
                    else if (direction == "right")
                    {
                        if (row >= 0 && row < rows && col >= 0 && col < beach[row].Length)
                        {
                            if (beach[row][col] == 'T')
                            {
                                oponentTokens++;
                                beach[row][col] = '-';
                            }

                            for (int i = 1; i < 4; i++)
                            {
                                if (row >= 0 && row < rows && col + i >= 0 && col + i < beach[row].Length && beach[row][col + i] == 'T')
                                {
                                    oponentTokens++;
                                    beach[row][col + i] = '-';
                                }
                            }
                        }
                    }
                }
                input = Console.ReadLine().Split();
            }

            foreach (var row in beach)
            {
                Console.WriteLine(string.Join(" ",row));
            }

            Console.WriteLine($"Collected tokens: {tokens}");
            Console.WriteLine($"Opponent's tokens: {oponentTokens}");
        }
    }
}
