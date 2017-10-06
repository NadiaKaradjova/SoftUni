namespace PokemonTrainer
{
    using System.Collections.Generic;

    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
