using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            this.name = name;
            this.element = element;
            this.Health = health;
        }

        public string Element { get { return this.element; } }        
    }
}
