using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private int alcoholLevel = 0;
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new Dictionary<string, Ingredient>();
        }

        public Dictionary<string, Ingredient> Ingredients { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int MaxAlcoholLevel { get; set; }

        public int CurrentAlcoholLevel => alcoholLevel;

        public void Add(Ingredient ingredient)
        {
            if (!Ingredients.ContainsKey(ingredient.Name) && Ingredients.Count < Capacity && ingredient.Alcohol+alcoholLevel <= MaxAlcoholLevel)
            {
                Ingredients.Add(ingredient.Name,ingredient);
                alcoholLevel += ingredient.Alcohol;
            }
        }

        public bool Remove(string name)
        {
            if (Ingredients.ContainsKey(name))
            {
                alcoholLevel -= Ingredients[name].Alcohol;
                return Ingredients.Remove(name);
            }

            return false;

        }

        public Ingredient FindIngredient(string name)
        {
            if (Ingredients.ContainsKey(name))
            {
                return Ingredients[name];
            }

            return null;
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            foreach (var coctail in Ingredients.OrderByDescending(x=>x.Value.Alcohol).Take(1))
            {
                return coctail.Value;
            }

            return null;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var coctail in Ingredients)
            {
                sb.AppendLine(coctail.Value.ToString());
            }

            return sb.ToString().TrimEnd();
        }



    }
}
