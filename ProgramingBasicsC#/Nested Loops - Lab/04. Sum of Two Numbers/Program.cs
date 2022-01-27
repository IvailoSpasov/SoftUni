using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int starOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            bool combinationHasBeenFound = false;
            for (int x = starOfInterval; x <= endOfInterval; x++)
            {
                for (int y = starOfInterval; y <= endOfInterval; y++)
                {
                    counter++;
                    if (x+y == magicNum)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x} + {y} = {magicNum})");
                        combinationHasBeenFound = true;
                        break;
                    }
                }
                if (combinationHasBeenFound)
                {
                    break;
                }
            }
            if (!combinationHasBeenFound)
            {
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
