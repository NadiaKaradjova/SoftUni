using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Map_Districts
{
    public class _08_Map_Districts
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var number = long.Parse(Console.ReadLine());
            var result = new Dictionary<string, List<long>>();

            for (int i = 0; i < input.Length; i++)
            {
                var line = input[i].Split(':');
                var city = line[0];
                var population = long.Parse(line[1]);

                if (!result.ContainsKey(city))
                {
                    result[city] = new List<long>();
                }
                result[city].Add(population);

            }           

            foreach (var city in result.Where(x => x.Value.Sum()>number).OrderByDescending(x => x.Value.Sum()))
            {
                var populationOfCity = city.Value.OrderByDescending(x => x).Take(5);
                Console.WriteLine($"{city.Key}: {string.Join(" ", populationOfCity)}");
            }
        }
    }
}
