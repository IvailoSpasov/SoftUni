using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        private string name;
        private double health;
        private double armor;
        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            Name = name;
            Health = health;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;

        }
        // TODO: Implement the rest of the class.

        public bool IsAlive { get; set; } = true;

        public string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }

                this.name = value;
            }
        }
        public abstract double BaseHealth { get; }

        public double Health
        {
            get => this.health;
            set
            {
                if (value > BaseHealth)
                {
                    this.health = BaseHealth;
                }
                else if (value <= 0)
                {
                    IsAlive = false;
                    this.health = 0;
                }
                else
                {
                    this.health = value;
                }
            }
        }
        public abstract double BaseArmor { get; }

        public double Armor
        {
            get => this.armor;
            set
            {
                if (value < 0)
                {
                    this.armor = 0;
                }

                this.armor = value;
            }

        }

        public double AbilityPoints { get; set; }

        public IBag Bag { get; set; }


        public void EnsureAlive()
        {
            if (!this.IsAlive)
            {
                throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
            }
        }

        public void TakeDamage(double hitPoints)
        {
            EnsureAlive();
            if (Armor - hitPoints < 0)
            {
                double healthToReduce = hitPoints - Armor;
                Armor = 0;
                Health -= healthToReduce;
            }
            else
            {
                Armor -= hitPoints;
            }
        }

        public void UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
        }

        public override string ToString()
        {
            string status = "Alive";
            if (!IsAlive)
            {
                status = "Dead";
            }

            return $"{Name} - HP: {health}/{BaseHealth}, AP: {armor}/{BaseArmor}, Status: {status}";
        }
    }
}