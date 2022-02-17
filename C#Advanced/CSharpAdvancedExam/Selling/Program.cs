using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] bakery = new char[n, n];

            int playerRow = 0;
            int playerCol = 0;
            int firstMirorRow = -1;
            int firstMirorCol = -1;
            int secondMirorRow = -1;
            int secondMirorCol = -1;

            for (int row = 0; row < n; row++)
            {
                string cols = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    bakery[row, col] = cols[col];
                    if (bakery[row, col] == 'S')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    if (bakery[row, col] == 'O' && firstMirorRow == -1)
                    {
                        firstMirorRow = row;
                        firstMirorCol = col;
                    }
                    else if (bakery[row, col] == 'O' && firstMirorRow > -1)
                    {
                        secondMirorRow = row;
                        secondMirorCol = col;
                    }
                }
            }

            int money = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (IsCordinatesValid(playerRow - 1, playerCol, n))
                    {

                        bakery[playerRow, playerCol] = '-';
                        playerRow--;

                        if (char.IsDigit(bakery[playerRow, playerCol]))
                        {
                            int value = int.Parse(bakery[playerRow, playerCol].ToString());
                            money += value;
                            bakery[playerRow, playerCol] = 'S';
                        }
                        else if (bakery[playerRow, playerCol] == 'O')
                        {
                            if (playerRow == firstMirorRow && playerCol == firstMirorCol)
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = secondMirorRow;
                                playerCol = secondMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                            else
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = firstMirorRow;
                                playerCol = firstMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                        }
                        else
                        {
                            bakery[playerRow, playerCol] = 'S';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {money}");
                        bakery[playerRow, playerCol] = '-';
                        PrintingMatrix(bakery);
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (IsCordinatesValid(playerRow + 1, playerCol, n))
                    {

                        bakery[playerRow, playerCol] = '-';
                        playerRow++;

                        if (char.IsDigit(bakery[playerRow, playerCol]))
                        {
                            int value = int.Parse(bakery[playerRow, playerCol].ToString());
                            money += value;
                            bakery[playerRow, playerCol] = 'S';
                        }
                        else if (bakery[playerRow, playerCol] == 'O')
                        {
                            if (playerRow == firstMirorRow && playerCol == firstMirorCol)
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = secondMirorRow;
                                playerCol = secondMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                            else
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = firstMirorRow;
                                playerCol = firstMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                        }
                        else
                        {
                            bakery[playerRow, playerCol] = 'S';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {money}");
                        bakery[playerRow, playerCol] = '-';
                        PrintingMatrix(bakery);
                        break;
                    }
                }
                else if (command == "left")
                {
                    if (IsCordinatesValid(playerRow, playerCol - 1, n))
                    {

                        bakery[playerRow, playerCol] = '-';
                        playerCol--;

                        if (char.IsDigit(bakery[playerRow, playerCol]))
                        {
                            int value = int.Parse(bakery[playerRow, playerCol].ToString());
                            money += value;
                            bakery[playerRow, playerCol] = 'S';
                        }
                        else if (bakery[playerRow, playerCol] == 'O')
                        {
                            if (playerRow == firstMirorRow && playerCol == firstMirorCol)
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = secondMirorRow;
                                playerCol = secondMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                            else
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = firstMirorRow;
                                playerCol = firstMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                        }
                        else
                        {
                            bakery[playerRow, playerCol] = 'S';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {money}");
                        bakery[playerRow, playerCol] = '-';
                        PrintingMatrix(bakery);
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (IsCordinatesValid(playerRow, playerCol + 1, n))
                    {

                        bakery[playerRow, playerCol] = '-';
                        playerCol++;

                        if (char.IsDigit(bakery[playerRow, playerCol]))
                        {
                            int value = int.Parse(bakery[playerRow, playerCol].ToString());
                            money += value;
                            bakery[playerRow, playerCol] = 'S';
                        }
                        else if (bakery[playerRow, playerCol] == 'O')
                        {
                            if (playerRow == firstMirorRow && playerCol == firstMirorCol)
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = secondMirorRow;
                                playerCol = secondMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                            else
                            {
                                bakery[playerRow, playerCol] = '-';
                                playerRow = firstMirorRow;
                                playerCol = firstMirorCol;
                                bakery[playerRow, playerCol] = 'S';
                            }
                        }
                        else
                        {
                            bakery[playerRow, playerCol] = 'S';
                        }
                    }
                    else
                    {
                        Console.WriteLine("Bad news, you are out of the bakery.");
                        Console.WriteLine($"Money: {money}");
                        bakery[playerRow, playerCol] = '-';
                        PrintingMatrix(bakery);
                        break;
                    }

                }

                if (money>=50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    Console.WriteLine($"Money: {money}");
                    PrintingMatrix(bakery);
                    break;
                }
            }
        }

        private static void PrintingMatrix(char[,] bakery)
        {
            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    Console.Write(bakery[row,col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsCordinatesValid(int playerRow, int playerCol, int i)
        {
            if (playerRow >= 0 && playerRow < i && playerCol >= 0 && playerCol < i)
            {
                return true;
            }

            return false;
        }
    }
}
