using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().Skip(1).ToList();
            ListyIterator<string> list = new ListyIterator<string>(elements);
            string action = Console.ReadLine();
            while (action!="END")
            {
                if (action== "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                    
                }
                else if (action == "Print")
                {
                    list.Print();
                }
                else if (action == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (action == "PrintAll")
                {
                    foreach (var item in elements)
                    {
                        Console.Write($"{item} ");
                    }

                    Console.WriteLine();
                }
                action = Console.ReadLine();
            }
        }
    }
}
