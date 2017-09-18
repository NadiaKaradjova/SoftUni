using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_Population_Counter
{
    public class _10_Population_Counter
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, int>>();
            var countryPopulation = new Dictionary<string, long>();
            var input = Console.ReadLine();

            while (input != "report")
            {
                var line = input.Split('|');
                var town = line[0];
                var country = line[1];
                var population = int.Parse(line[2]);

                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, int>();
                    countryPopulation[country] = 0;
                }
                var towns = result[country];
                if (!towns.ContainsKey(town))
                {
                    towns[town] = 0;
                }
                towns[town] = population;
                countryPopulation[country] += population;

                input = Console.ReadLine();
            }

            foreach (var country in countryPopulation.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                var currentTown = result.First(x => x.Key == country.Key);
                var towns = currentTown.Value;
                foreach (var item in towns.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }
            }
        }
    }
}
