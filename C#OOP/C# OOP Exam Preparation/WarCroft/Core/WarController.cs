using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
    {
        private List<Character> characters;
        private List<Item> items;
        public WarController()
        {
            characters = new List<Character>();
            items = new List<Item>();
        }

        public string JoinParty(string[] args)
        {
            string type = args[0];
            string name = args[1];
            if (type != "Warrior" && type != "Priest")
            {
                throw new ArgumentException($"Invalid character type \"{type}\"!");
            }

            Character character;
            if (type == "Warrior")
            {
                character = new Warrior(name);
            }
            else
            {
                character = new Priest(name);
            }
            characters.Add(character);
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            string type = args[0];
            if (type!="FirePotion"&&type!="HealthPotion")
            {
                throw new ArgumentException($"Invalid item \"{type}\"!");
            }

            Item item;
            if (type == "FirePotion")
            {
                item = new FirePotion();
            }
            else
            {
                item = new HealthPotion();
            }
            items.Add(item);
            return $"{type} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            string name = args[0];
            Character character = characters.FirstOrDefault(x => x.Name == name);
            if (character == null)
            {
                throw new ArgumentException($"Character {name} not found!");

            }

            if (items.Count==0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }

            var item = items[items.Count - 1];
            items.RemoveAt(items.Count-1);
            character.Bag.AddItem(item);
            return $"{name} picked up {item.GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            string characterName = args[0];
            string itemName = args[1];
            Character character = characters.FirstOrDefault(x => x.Name == characterName);
            if (character==null)
            {
                throw new ArgumentException("Character {name} not found!");
            }
            character.UseItem(character.Bag.GetItem(itemName));
            return $"{character.Name} used {itemName}.";
        }

        public string GetStats()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var character in characters)
            {
                sb.AppendLine(character.ToString());
            }

            return sb.ToString().TrimEnd();
        }

        public string Attack(string[] args)
        {
            string attackerName = args[0];
            string defenderName = args[1];
            Character attacker = characters.FirstOrDefault(x => x.Name == attackerName);
            Character defender = characters.FirstOrDefault(x => x.Name == defenderName);
            if (attacker == null)
            {
                throw new ArgumentException($"Character {attackerName} not found!");
            }

            if (defender == null)
            {
                throw new ArgumentException($"Character {defenderName} not found!");
            }

            if (attacker.GetType().Name!="Warrior")
            {
                throw new ArgumentException($"{attacker.Name} cannot attack!");
            }

            Warrior warrior = attacker as Warrior;
            warrior.Attack(defender);
            if (defender.IsAlive)
            {
                return
                    $"{attackerName} attacks {defenderName} for {attacker.AbilityPoints} hit points! {defenderName} has {defender.Health}/{defender.BaseHealth} HP and {defender.Armor}/{defender.BaseArmor} AP left!";
            }
            else
            {
                return
                    $"{attackerName} attacks {defenderName} for {attacker.AbilityPoints} hit points! {defenderName} has {defender.Health}/{defender.BaseHealth} HP and {defender.Armor}/{defender.BaseArmor} AP left!\n{ defender.Name} is dead!";
            }
            
        }

        public string Heal(string[] args)
        {
            string healerName = args[0];
            string recieverName = args[1];
            Character healer = characters.FirstOrDefault(x => x.Name == healerName);
            Character reciever = characters.FirstOrDefault(x => x.Name == recieverName);
            if (healer == null)
            {
                throw new ArgumentException($"Character {healerName} not found!");
            }

            if (reciever == null)
            {
                throw new ArgumentException($"Character {recieverName} not found!");
            }

            if (healer.GetType().Name != "Priest")
            {
                throw new ArgumentException($"{healerName} cannot heal!");
            }

            Priest healerr = healer as Priest;
            healerr.Heal(reciever);
            return
                $"{healerr.Name} heals {reciever.Name} for {healerr.AbilityPoints}! {reciever.Name} has {reciever.Health} health now!";
        }
    }
}
