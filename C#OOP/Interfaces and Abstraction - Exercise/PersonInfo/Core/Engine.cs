using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PersonInfo
{
    public class Engine
    {
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                IBuyer buyer = null;
                if (input.Length == 4)
                {
                    buyer = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                }
                else
                {
                    buyer = new Rebel(input[0], int.Parse(input[1]), input[2]);
                }
                buyers.Add(input[0], buyer);


            }

            string name = Console.ReadLine();
            while (name != "End")
            {
                if (buyers.ContainsKey(name))
                {
                    buyers[name].BuyFood();
                }
                name = Console.ReadLine();
            }

            int sum = buyers.Sum(x => x.Value.Food);
            Console.WriteLine(sum);

        }
    }
}
