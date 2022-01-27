using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int health = int.Parse(input[1]);
                int mana = int.Parse(input[2]);
                if (health > 100)
                {
                    health = 100;
                }
                if (mana > 200)
                {
                    mana = 200;
                }

                Hero hero = new Hero();
                hero.HP = health;
                hero.MP = mana;
                heroes.Add(name, hero);
            }

            string[] commands = Console.ReadLine().Split(" - ");
            while (commands[0] != "End")
            {
                string cmd = commands[0];
                if (cmd == "CastSpell")
                {
                    string name = commands[1];
                    int manaNeeded = int.Parse(commands[2]);
                    string spellName = commands[3];
                    if (heroes[name].MP >= manaNeeded)
                    {
                        heroes[name].MP -= manaNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroes[name].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmd == "TakeDamage")
                {
                    string name = commands[1];
                    int damage = int.Parse(commands[2]);
                    string attacker = commands[3];
                    heroes[name].HP -= damage;
                    if (heroes[name].HP <= 0)
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroes.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroes[name].HP} HP left!");
                    }
                }
                else if (cmd == "Recharge")
                {
                    string name = commands[1];
                    int amount = int.Parse(commands[2]);
                    int currMana = heroes[name].MP;
                    heroes[name].MP += amount;
                    if (heroes[name].MP > 200)
                    {
                        heroes[name].MP = 200;
                        Console.WriteLine($"{name} recharged for {heroes[name].MP-currMana} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} recharged for {amount} MP!");
                    }
                }
                else if (cmd == "Heal")
                {
                    string name = commands[1];
                    int amount = int.Parse(commands[2]);
                    int currHealth = heroes[name].HP;
                    heroes[name].HP += amount;
                    if (heroes[name].HP > 100)
                    {
                        heroes[name].HP = 100;
                        Console.WriteLine($"{name} healed for {heroes[name].HP - currHealth} HP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} healed for {amount} HP!");
                    }
                }
                commands = Console.ReadLine().Split(" - ");
            }

            foreach (var hero in heroes.OrderByDescending(x=>x.Value.HP).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{hero.Key}\n  HP: {hero.Value.HP}\n  MP: {hero.Value.MP}");

            }

        }
    }
}
