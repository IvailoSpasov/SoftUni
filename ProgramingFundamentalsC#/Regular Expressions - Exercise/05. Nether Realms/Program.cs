using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regexForHealth = new Regex(@"[^\+\-\*\/0-9\.]");
            Regex regexForDamage = new Regex(@"-?\d+\.?\d*");
            Regex regexMulDiv = new Regex(@"[\*\/]");
            Regex regexSplit = new Regex(@"[,\s]+");
            string input = Console.ReadLine();
            string[] demons = regexSplit.Split(input).OrderBy(x => x).ToArray();
            for (int i = 0; i < demons.Length; i++)
            {
                int health = 0;
                MatchCollection charMatch = regexForHealth.Matches(demons[i]);
                foreach (Match match in charMatch)
                {
                    health += char.Parse(match.ToString());
                }

                double damage = 0;
                MatchCollection damageMatch = regexForDamage.Matches(demons[i]);
                foreach (Match match in damageMatch)
                {
                    double currDmg = double.Parse(match.ToString());
                    damage += currDmg;
                }

                MatchCollection matchDivMul = regexMulDiv.Matches(demons[i]);
                foreach (Match match in matchDivMul)
                {
                    string symbul = match.ToString();
                    if (symbul=="/")
                    {
                        damage /= 2;
                    }
                    else
                    {
                        damage *= 2;
                    }
                }

                Console.WriteLine($"{demons[i]} - {health} health, {damage:f2} damage");
            }
        }
    }
}
