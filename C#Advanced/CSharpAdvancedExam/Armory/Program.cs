using System;

namespace Armory
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsAndCols = int.Parse(Console.ReadLine());
            char[,] swordShop = new Char[rowsAndCols, rowsAndCols];
            int officerRow = 0;
            int officerCow = 0;
            int mirrorOneRow = -1;
            int mirrorOneCol = -1;
            int mirrorTwoRow = -1;
            int mirrorTwoCol = -1;
            for (int rowIndex = 0; rowIndex < rowsAndCols; rowIndex++)
            {
                string rows = Console.ReadLine().Trim();
                for (int coIndex = 0; coIndex < rowsAndCols; coIndex++)
                {
                    swordShop[rowIndex, coIndex] = rows[coIndex];
                    if (swordShop[rowIndex, coIndex] == 'A')
                    {
                        officerRow = rowIndex;
                        officerCow = coIndex;
                    }

                    if (swordShop[rowIndex, coIndex] == 'M')
                    {
                        if (mirrorOneCol == -1)
                        {
                            mirrorOneCol = coIndex;
                            mirrorOneRow = rowIndex;
                        }
                        else
                        {
                            mirrorTwoCol = coIndex;
                            mirrorTwoRow = rowIndex;
                        }
                    }
                }
            }

            int gold = 0;
            while (true)
            {
                string command = Console.ReadLine().Trim();
                if (command == "up")
                {
                    if (isValidIndex(swordShop, officerRow - 1, officerCow))
                    {
                        if (swordShop[officerRow - 1, officerCow] == 'M')
                        {
                            swordShop[officerRow, officerCow] = '-';
                            if (officerRow-1 == mirrorOneRow && officerCow == mirrorOneCol)
                            {
                                swordShop[mirrorOneRow, mirrorOneCol] = '-';
                                swordShop[mirrorTwoRow, mirrorTwoCol] = 'A';
                                officerRow = mirrorTwoRow;
                                officerCow = mirrorTwoCol;
                            }
                            else
                            {
                                swordShop[mirrorTwoRow, mirrorTwoCol] = '-';
                                swordShop[mirrorOneRow, mirrorOneCol] = 'A';
                                officerRow = mirrorOneRow;
                                officerCow = mirrorOneCol;
                            }
                        }
                        else if (char.IsDigit(swordShop[officerRow - 1, officerCow]))
                        {
                            gold += int.Parse(swordShop[officerRow - 1, officerCow].ToString());
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow - 1, officerCow] = 'A';
                            officerRow = officerRow - 1;
                        }
                        else
                        {
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow - 1, officerCow] = 'A';
                            officerRow = officerRow - 1;
                        }
                    }
                    else
                    {
                        swordShop[officerRow, officerCow] = '-';
                        PrintingLeavingShop(gold, swordShop);
                        return;
                    }
                }
                else if (command == "down")
                {
                    if (isValidIndex(swordShop, officerRow + 1, officerCow))
                    {
                        if (swordShop[officerRow + 1, officerCow] == 'M')
                        {
                            swordShop[officerRow, officerCow] = '-';
                            if (officerRow+1 == mirrorOneRow && officerCow == mirrorOneCol)
                            {
                                swordShop[mirrorOneRow, mirrorOneCol] = '-';
                                swordShop[mirrorTwoRow, mirrorTwoCol] = 'A';
                                officerRow = mirrorTwoRow;
                                officerCow = mirrorTwoCol;
                            }
                            else
                            {
                                swordShop[mirrorTwoRow, mirrorTwoCol] = '-';
                                swordShop[mirrorOneRow, mirrorOneCol] = 'A';
                                officerRow = mirrorOneRow;
                                officerCow = mirrorOneCol;
                            }
                        }
                        else if (char.IsDigit(swordShop[officerRow + 1, officerCow]))
                        {
                            gold += int.Parse(swordShop[officerRow + 1, officerCow].ToString());
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow + 1, officerCow] = 'A';
                            officerRow = officerRow + 1;
                        }
                        else
                        {
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow + 1, officerCow] = 'A';
                            officerRow = officerRow + 1;
                        }
                    }
                    else
                    {
                        swordShop[officerRow, officerCow] = '-';
                        PrintingLeavingShop(gold, swordShop);
                        return;
                    }
                }
                else if (command == "left")
                {
                    if (isValidIndex(swordShop, officerRow, officerCow - 1))
                    {
                        if (swordShop[officerRow, officerCow - 1] == 'M')
                        {
                            swordShop[officerRow, officerCow] = '-';
                            if (officerRow == mirrorOneRow && officerCow-1 == mirrorOneCol)
                            {
                                swordShop[mirrorOneRow, mirrorOneCol] = '-';
                                swordShop[mirrorTwoRow, mirrorTwoCol] = 'A';
                                officerRow = mirrorTwoRow;
                                officerCow = mirrorTwoCol;
                            }
                            else
                            {
                                swordShop[mirrorTwoRow, mirrorTwoCol] = '-';
                                swordShop[mirrorOneRow, mirrorOneCol] = 'A';
                                officerRow = mirrorOneRow;
                                officerCow = mirrorOneCol;
                            }
                        }
                        else if (char.IsDigit(swordShop[officerRow, officerCow - 1]))
                        {
                            gold += int.Parse(swordShop[officerRow, officerCow - 1].ToString());
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow, officerCow - 1] = 'A';
                            officerCow = officerCow - 1;
                        }
                        else
                        {
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow, officerCow - 1] = 'A';
                            officerCow = officerCow - 1;
                        }
                    }
                    else
                    {
                        swordShop[officerRow, officerCow] = '-';
                        PrintingLeavingShop(gold, swordShop);
                        return;
                    }
                }
                else if (command == "right")
                {
                    if (isValidIndex(swordShop, officerRow, officerCow + 1))
                    {
                        if (swordShop[officerRow, officerCow + 1] == 'M')
                        {
                            swordShop[officerRow, officerCow] = '-';
                            if (officerRow == mirrorOneRow && officerCow+1 == mirrorOneCol)
                            {
                                swordShop[mirrorOneRow, mirrorOneCol] = '-';
                                swordShop[mirrorTwoRow, mirrorTwoCol] = 'A';
                                officerRow = mirrorTwoRow;
                                officerCow = mirrorTwoCol;
                            }
                            else
                            {
                                swordShop[mirrorTwoRow, mirrorTwoCol] = '-';
                                swordShop[mirrorOneRow, mirrorOneCol] = 'A';
                                officerRow = mirrorOneRow;
                                officerCow = mirrorOneCol;
                            }
                        }
                        else if (char.IsDigit(swordShop[officerRow, officerCow + 1]))
                        {
                            gold += int.Parse(swordShop[officerRow, officerCow + 1].ToString());
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow, officerCow + 1] = 'A';
                            officerCow = officerCow + 1;
                        }
                        else
                        {
                            swordShop[officerRow, officerCow] = '-';
                            swordShop[officerRow, officerCow + 1] = 'A';
                            officerCow = officerCow + 1;
                        }
                    }
                    else
                    {
                        swordShop[officerRow, officerCow] = '-';
                        PrintingLeavingShop(gold, swordShop);
                        return;
                    }
                }

                if (gold >= 65)
                {
                    Console.WriteLine("Very nice swords, I will come back for more!");
                    Console.WriteLine($"The king paid {gold} gold coins.");
                    for (int row = 0; row < rowsAndCols; row++)
                    {
                        for (int col = 0; col < rowsAndCols; col++)
                        {
                            Console.Write(swordShop[row, col]);
                        }

                        Console.WriteLine();
                    }

                    return;
                }
            }
        }

        private static void PrintingLeavingShop(int gold, char[,] swordShop)
        {
            Console.WriteLine("I do not need more swords!");
            Console.WriteLine($"The king paid {gold} gold coins.");
            for (int row = 0; row < swordShop.GetLength(0); row++)
            {
                for (int col = 0; col < swordShop.GetLength(1); col++)
                {
                    Console.Write(swordShop[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool isValidIndex(char[,] swordShop, int officerRow, int officerCow)
        {
            if (officerRow >= 0 && officerCow >= 0 && officerRow < swordShop.GetLength(0) &&
                officerCow < swordShop.GetLength(1))
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

