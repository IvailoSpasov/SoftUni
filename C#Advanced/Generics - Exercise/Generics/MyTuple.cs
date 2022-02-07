﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Generics
{
    public class MyTuple<T1,T2,T3>
    {
        public MyTuple(T1 item1,T2 item2,T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;

        }
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }

    
}
