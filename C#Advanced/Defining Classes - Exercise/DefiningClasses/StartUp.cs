using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (input[0] != "Tournament")
            {
                string trainerName = input[0];
                string pokemonName = input[1];
                string element = input[2];
                int health = int.Parse(input[3]);
                Trainer trainer = new Trainer(trainerName);
                Pokemon pokemon = new Pokemon(pokemonName, element, health);
                trainer.Pokemons.Add(pokemon);
                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, trainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(pokemon);
                }
                input = Console.ReadLine().Split();
            }

            string action = Console.ReadLine();
            while (action != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (!trainer.Value.Pokemons.Any(x => x.Element == action))
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                    else
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                }

                foreach (var trainer in trainers)
                {
                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }

                action = Console.ReadLine();
            }

            foreach (var keyValuePair in trainers.OrderByDescending(x => x.Value.NumberOfBadges))
            {
                Console.WriteLine($"{keyValuePair.Value.Name} {keyValuePair.Value.NumberOfBadges} {keyValuePair.Value.Pokemons.Count}");
            }
        }
    }
}
