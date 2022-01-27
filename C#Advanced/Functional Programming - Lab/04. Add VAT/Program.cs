using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(", ").Select(double.Parse).ToList();
            numbers = numbers.Select(x => x * 1.2).ToList();
            numbers.ForEach(x=>Console.WriteLine($"{x:f2}"));
        }
    }
}
