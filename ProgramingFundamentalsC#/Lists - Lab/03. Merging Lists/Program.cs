using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int largestList = list1.Count;
            if (list1.Count < list2.Count)
            {
                largestList = list2.Count;
            }

            List<int> mergedList = new List<int>();

            for (int i = 0; i < largestList; i++)
            {
                if (list1.Count > i)
                {
                    mergedList.Add(list1[i]);
                }

                if (list2.Count > i)
                {
                    mergedList.Add(list2[i]);
                }
            }

            Console.WriteLine(string.Join(" ",mergedList));
        }
    }
}
