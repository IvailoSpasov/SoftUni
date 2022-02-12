using System;
using System.Collections.Generic;
using System.Linq;

namespace Froggy
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            List<int> stones = new List<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Lake lake = new Lake(stones);
            Console.WriteLine(string.Join(", ",lake));
        }
    }
}
