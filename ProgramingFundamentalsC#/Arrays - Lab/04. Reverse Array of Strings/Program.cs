using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length/2; i++)
            {
                string tmp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i -1] = tmp;

            }

            foreach (var leters in input)
            {
                Console.Write(leters+" ");
            }
        }
    }
}
