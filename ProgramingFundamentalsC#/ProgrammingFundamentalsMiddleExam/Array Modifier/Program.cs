using System;
using System.ComponentModel.Design;
using System.Linq;

namespace Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "end")
            {
                if (input[0] == "decrease")
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] -= 1;
                    }
                }

                else if (input[0] == "swap")
                {
                    int firstElement = int.Parse(input[1]);
                    int secondElement = int.Parse(input[2]);
                    int temp = arr[firstElement];
                    arr[firstElement] = arr[secondElement];
                    arr[secondElement] = temp;
                }
                else if (input[0] == "multiply")
                {
                    int firstElement = int.Parse(input[1]);
                    int secondElement = int.Parse(input[2]);
                    arr[firstElement] = arr[firstElement] * arr[secondElement];
                }

                input = Console.ReadLine().Split();

            }

            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
