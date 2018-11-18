using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int numberOfBadges;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int NumberOfBadges
        {
            get { return this.numberOfBadges; }
            set { this.numberOfBadges = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public Trainer(string name)
        {
            this.name = name;
            this.numberOfBadges = 0;
        }

        public bool HasElement(string element )
        {
            bool hasElement = false;

            foreach (var pokemon in this.pokemons )
            {
                if (pokemon.Element == element)
                {
                    hasElement = true;
                }
            }
            return hasElement;
        }

        public void LooseHealth()
        {
            for (int i = 0; i < this.pokemons.Count; i++)
            {
                if (pokemons[0].Health>=10)
                {
                    pokemons[0].Health -= 10;
                }
                else
                {
                    pokemons.Remove(pokemons[i]);
                }
            }
        }

    }
}
