using System;
using System.Linq;

namespace The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int waitingPeople = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 4)
                {
                    while (arr[i] != 4)
                    {
                        if (waitingPeople != 0)
                        {
                            arr[i]++;
                            waitingPeople--;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            if (arr[arr.Length - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", arr));
            }
            else if (waitingPeople > 0)
            {
                Console.WriteLine($"There isn't enough space! {waitingPeople} people in a queue!");
                Console.WriteLine(string.Join(" ",arr));
            }
            else
            {
                Console.WriteLine(string.Join(" ",arr));
            }



        }
    }
}
