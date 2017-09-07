using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_Worms_World_Party
{
    public class _4_Worms_World_Party
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, long>>();
            var temp = new List<string>();

            var pattern = new Regex(@"([A-Za-z0-9\s+]+)\s->\s([A-Za-z0-9\s+]+)\s->\s(\d+)");

            var input = Console.ReadLine();

            while (input != "quit")
            {
                var line = pattern.Match(input);

                var teamName = line.Groups[2].Value;
                var wormName = line.Groups[1].Value;
                var wormScore = long.Parse(line.Groups[3].Value);

                if (temp.Contains(wormName))
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                if (!result.ContainsKey(teamName))
                {
                    result[teamName] = new Dictionary<string, long>();
                }

                
                if (!result[teamName].ContainsKey(wormName) && !temp.Contains(wormName))
                {
                    temp.Add(wormName);
                    result[teamName][wormName] = wormScore;
                }

                input = Console.ReadLine();
            }

            var resultSum = new Dictionary<string, long>();

            foreach (var item in result)
            {
                var team = item.Value;
                long sum = team.Values.Sum();
                resultSum.Add(item.Key, sum);
            }

            var number = 1;
            foreach (var item in resultSum.OrderByDescending(x => x.Value).ThenByDescending(z => z.Value/result[z.Key].Count))
            {
                Console.WriteLine($"{number}. Team: {item.Key} - {item.Value}");
                number++;

                foreach (var teamName in result.Where(x => x.Key == item.Key))
                {
                    var team = teamName.Value.OrderByDescending(y => y.Value);

                    foreach (var item1 in team)
                    {
                        Console.WriteLine($"###{item1.Key} : {item1.Value}");
                    }
                }                

            }

        }
    }
}
