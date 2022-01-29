using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Reverse().ToArray();
            int n = int.Parse(Console.ReadLine());
            Func<int[], int, int[]> IsDivisibleByNum = (array,n) => array.Where(x => x % n != 0).ToArray();
            int[] result = IsDivisibleByNum(numbers,n);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
