using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_NSA
{
    public class _4_NSA
    {
        public static void Main()
        {

            var result = new Dictionary<string, Dictionary<string, int>>();

            var pattern = new Regex(@"(^[A-Za-z0-9]+)\s+->\s+([A-Za-z0-9]+)\s+->\s+(\d+)$");

            var input = Console.ReadLine();

            while (input != "quit")
            {
                var line = pattern.Match(input);

                var country = line.Groups[1].Value;
                var spy = line.Groups[2].Value;
                var daysInService = int.Parse(line.Groups[3].Value);

                if (!result.ContainsKey(country))
                {
                    result[country] = new Dictionary<string, int>();
                }

                if (!result[country].ContainsKey(spy))
                {
                    result[country][spy] = 0;
                }
                result[country][spy] = daysInService;

                input = Console.ReadLine();
            }

            foreach (var country in result.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                var spies = country.Value;

                foreach (var spy in spies.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }

            }
        }
    }
}
