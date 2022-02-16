using System;
using System.Linq;

namespace Warships
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            string[] input = Console.ReadLine().Split(",",StringSplitOptions.RemoveEmptyEntries);

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;

            for (int row = 0; row < n; row++)
            {
                char[] cols = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    field[row, col] = cols[col];
                    if (field[row, col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (field[row, col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            int totalShips = firstPlayerShips + secondPlayerShips;

            for (int i = 0; i < input.Length; i++)
            {
                int[] splited = input[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int row = splited[0];
                int col = splited[1];
                if (IsCordinatesValid(row, col, field) && field[row, col] == '<')
                {
                    firstPlayerShips--;
                    field[row, col] = 'X';
                }
                else if (IsCordinatesValid(row, col, field) && field[row, col] == '>')
                {
                    secondPlayerShips--;
                    field[row, col] = 'X';
                }
                else if (IsCordinatesValid(row, col, field) && field[row, col] == '#')
                {
                    for (int r = row - 1; r <= row + 1; r++)
                    {
                        for (int c = col - 1; c <= col + 1; c++)
                        {
                            if (IsCordinatesValid(r, c, field))
                            {
                                if (field[r, c] == '<')
                                {
                                    firstPlayerShips--;
                                    field[row, col] = 'X';
                                }

                                else if (field[r, c] == '>')
                                {
                                    secondPlayerShips--;
                                    field[row, col] = 'X';
                                }
                                else
                                {
                                    field[row, col] = 'X';
                                }

                            }
                        }
                    }
                }

                if (firstPlayerShips == 0)
                {
                    Console.WriteLine($"Player Two has won the game! {totalShips - (firstPlayerShips + secondPlayerShips)} ships have been sunk in the battle.");
                    break;
                }
                else if (secondPlayerShips == 0)
                {
                    Console.WriteLine($"Player One has won the game! {totalShips - (firstPlayerShips + secondPlayerShips)} ships have been sunk in the battle.");
                    break;
                }
            }

            if (firstPlayerShips > 0 && secondPlayerShips > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }
        }

        private static bool IsCordinatesValid(int row, int col, char[,] field)
        {
            if (row >= 0 && row < field.GetLength(0) && col >= 0 && col < field.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
