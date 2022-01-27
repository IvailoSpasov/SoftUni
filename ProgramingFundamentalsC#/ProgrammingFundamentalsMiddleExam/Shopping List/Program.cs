using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shopingList = Console.ReadLine().Split("!").ToList();
            string[] cmd = Console.ReadLine().Split().ToArray();

            while (cmd[0] != "Go")
            {
                if (cmd[0] == "Urgent")
                {
                    if (!shopingList.Contains(cmd[1]))
                    {
                        shopingList.Insert(0, cmd[1]);
                    }
                }
                else if (cmd[0] == "Unnecessary")
                {
                    if (shopingList.Contains(cmd[1]))
                    {
                        shopingList.Remove(cmd[1]);
                    }
                }
                else if (cmd[0] == "Correct")
                {
                    if (shopingList.Contains(cmd[1]))
                    {
                        int indexOne = shopingList.IndexOf(cmd[1]);
                        shopingList[indexOne] = cmd[2];
                    }
                }
                else if (cmd[0] == "Rearrange")
                {
                    if (shopingList.Contains(cmd[1]))
                    {
                        shopingList.Remove(cmd[1]);
                        shopingList.Add(cmd[1]);
                    }
                }

                cmd = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine(string.Join(", ",shopingList));
        }
    }
}
