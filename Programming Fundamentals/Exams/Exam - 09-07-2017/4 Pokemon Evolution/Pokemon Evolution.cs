using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Pokemon_Evolution
{
    public class _4_Pokemon_Evolution
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<Evolution>>();
            var input = Console.ReadLine();

            while (input != "wubbalubbadubdub")
            {
                var line = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var pokemonName = line[0];

                if (line.Length == 1 )
                {
                    if (result.ContainsKey(pokemonName))
                    {
                        Console.WriteLine($"# {pokemonName}");
                        foreach (var item in result[pokemonName])
                        {
                            Console.WriteLine($"{item.EvolutionType} <-> {item.EvolutionIndex}");
                        }
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }                    
                }
                else
                {
                    var evolutionType = line[1];
                    var evolutionIndex = int.Parse(line[2]);

                    var currentEvo = new Evolution() { EvolutionType = evolutionType, EvolutionIndex = evolutionIndex };

                    if (!result.ContainsKey(pokemonName))
                    {
                        result[pokemonName] = new List<Evolution>();
                    }

                    result[pokemonName].Add(currentEvo);
                }  

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"# {item.Key}");
                var evo = item.Value;
                foreach (var item1 in evo.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{item1.EvolutionType} <-> {item1.EvolutionIndex}");
                }
            }
        }
    }

    public class Evolution
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }
    }
}
