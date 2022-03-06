using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> raid = new List<BaseHero>();
            while (true)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                BaseHero hero;
                if (type == "Paladin")
                {
                    hero = new Paladin(name);
                }
                else if (type == "Druid")
                {
                    hero = new Druid(name);
                }
                else if (type == "Rogue")
                {
                    hero = new Rogue(name);
                }
                else if (type == "Warrior")
                {
                    hero = new Warrior(name);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                    continue;
                }

                raid.Add(hero);
                if (raid.Count == n)
                {
                    break;
                }
            }

            int bossHealth = int.Parse(Console.ReadLine());

            foreach (var hero in raid)
            {
                Console.WriteLine(hero.CastAbility());
            }

            if (raid.Count > 0 && raid.Select(x => x.Power).Sum() >= bossHealth)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
