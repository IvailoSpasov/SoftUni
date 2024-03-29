﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int wastedWater = 0;
            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currBotle = bottles.Peek();
                int currCup = cups.Peek();
                if (currCup < currBotle)
                {
                    wastedWater += currBotle - currCup;
                    cups.Dequeue();
                    bottles.Pop();
                }
                else
                {
                    while (currCup > 0)
                    {
                        currCup -= bottles.Pop();
                        if (currCup <= 0)
                        {
                            wastedWater += Math.Abs(currCup);
                            cups.Dequeue();
                        }
                    }
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
