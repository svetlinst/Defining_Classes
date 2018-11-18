using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
            while (input[0]!="Tournament")
            {
                var trainerName = input[0];
                var pokemonName = input[1];
                var element = input[2];
                var health = int.Parse(input[3]);
                Pokemon currPokemon = new Pokemon(pokemonName, element, health);
                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer currTrainer = new Trainer(trainerName);
                    currTrainer.Pokemons.Add(currPokemon);
                    trainers.Add(trainerName,currTrainer);
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(currPokemon);
                }

                input = Console.ReadLine().Split().ToArray();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.HasElement(command))
                    {
                        trainer.NumberOfBadges++;

                    }
                    else
                    {
                        trainer.LooseHealth();

                    }
                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.Values.OrderByDescending(t=>t.NumberOfBadges))
            {
                var pokesum = trainer.Pokemons.Count;
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {pokesum}");
            }
        }
    }
}
