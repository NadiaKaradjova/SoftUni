namespace PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Pokemon_Trainer
    {
        public static void Main()
        {

            var trainers = new List<Trainer>();
            var pokemons = new Dictionary<string, List<Pokemon>>();

            var input = Console.ReadLine();
            while (input != "Tournament")
            {
                var info = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var trainer = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                if (!pokemons.ContainsKey(trainer))
                {
                    pokemons[trainer] = new List<Pokemon>();
                }
                pokemons[trainer].Add(pokemon);

                if (!trainers.Any(x => x.Name == trainer))
                {
                    var currentTrainer = new Trainer(trainer);
                    trainers.Add(currentTrainer);
                }

                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                foreach (var trainer in trainers.Where(x => x.Name == pokemon.Key))
                {
                    trainer.Pokemons = pokemon.Value;
                }
            }

            var command = Console.ReadLine();

            while (command != "End")
            {
                CommandManipulation(command, trainers);
                command = Console.ReadLine();
            }


            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }

        private static void CommandManipulation(string command, List<Trainer> trainers)
        {
            foreach (var trainer in trainers)
            {
                var pokemons = trainer.Pokemons;
                if (pokemons.Any(x => x.Element == command))
                {
                    trainer.NumberOfBadges++;
                }
                else
                {
                    foreach (var pokemon in pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }

                var pok = pokemons.Where(x => x.Health > 0).ToList();
                trainer.Pokemons = pok;                
            }
        }
    }
}
