using System;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> periodicTable = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string [] elementArray = Console.ReadLine().Split();
                foreach (var element in elementArray)
                {
                    periodicTable.Add(element);
                }
            }

            foreach (var element in periodicTable)
            {
                Console.Write(element+" ");
            }
        }
    }
}
