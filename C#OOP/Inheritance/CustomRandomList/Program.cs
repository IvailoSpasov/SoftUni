﻿using System;

namespace CustomRandomList
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList()
            {
                "pesho",
                "gosho",
                "kiro"
            };
            Console.WriteLine(list.RandomString());
        }
    }
}
