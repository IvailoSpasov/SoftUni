using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            Dictionary<string, List<string>> companys = new Dictionary<string, List<string>>();
            while (input[0]!="End")
            {
                string company = input[0];
                string ID = input[1];
                if (!companys.ContainsKey(company))
                {
                    companys.Add(company,new List<string>(){ID});
                }
                else
                {
                    if (!companys[company].Contains(ID))
                    {
                        companys[company].Add(ID);
                    }
                }
                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companys.OrderBy(x=>x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
