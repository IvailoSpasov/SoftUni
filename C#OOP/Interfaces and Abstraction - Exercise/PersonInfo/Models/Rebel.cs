﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Rebel : IPerson, IBuyer
    {
        public Rebel(string name, int age, string @group)
        {
            Name = name;
            Age = age;
            Group = @group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Group { get; set; }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
