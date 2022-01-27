using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int money = int.Parse(Console.ReadLine());

            int bulletsCounter = 0;
            while (true)
            {
                if (bulletsCounter == gunBarrel && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    bulletsCounter = 0;
                }


                if (locks.Peek() >= bullets.Peek())
                {
                    locks.Dequeue();
                    bullets.Pop();
                    bulletsCounter++;
                    money -= bulletPrice;
                    Console.WriteLine("Bang!");
                }
                else
                {
                    bullets.Pop();
                    bulletsCounter++;
                    money -= bulletPrice;
                    Console.WriteLine("Ping!");
                }

                if (locks.Count == 0)
                {
                    if (bulletsCounter == gunBarrel && bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        bulletsCounter = 0;
                    }
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${money}");
                    return;
                }

                if (bullets.Count == 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    return;
                }
            }
        }
    }
}
