using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Football_Standings
{
    public class _3_Football_Standings
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);

            var symbol1 = new Regex($@"{key}(\w*){key}.+?{key}(\w*){key}.+?(\d+:\d+)");

            var input = Console.ReadLine();

            var points = new Dictionary<string, int>();
            var goals = new Dictionary<string, int>();

            while (input != "final")
            {
                var line = symbol1.Match(input);
                var firstTeam = line.Groups[1].ToString().ToUpper();
                var secondTeam = line.Groups[2].ToString().ToUpper();

                firstTeam = new string(firstTeam.Reverse().ToArray());
                secondTeam = new string(secondTeam.Reverse().ToArray());

                var result = line.Groups[3].ToString().Split(':').ToArray();
                var resultFirstTeam = int.Parse(result[0]);
                var resultSecondTeam = int.Parse(result[1]);

                // Dictionary POINTS
                
                if (resultFirstTeam > resultSecondTeam)
                {
                    if (!points.ContainsKey(firstTeam))
                    {
                        points[firstTeam] = 0;
                    }
                    points[firstTeam] += 3;

                    if (!points.ContainsKey(secondTeam))
                    {
                        points[secondTeam] = 0;
                    }
                }

                else if (resultFirstTeam < resultSecondTeam)
                {
                    if (!points.ContainsKey(firstTeam))
                    {
                        points[firstTeam] = 0;
                    }
                   
                    if (!points.ContainsKey(secondTeam))
                    {
                        points[secondTeam] = 0;
                    }
                    points[secondTeam] += 3;
                }

                else if (resultFirstTeam == resultSecondTeam)
                {
                    if (!points.ContainsKey(firstTeam))
                    {
                        points[firstTeam] = 0;
                    }
                    points[firstTeam] += 1;

                    if (!points.ContainsKey(secondTeam))
                    {
                        points[secondTeam] = 0;
                    }
                    points[secondTeam] += 1;
                }

                // Dictionary GOALS

                if (!goals.ContainsKey(firstTeam))
                {
                    goals[firstTeam] = 0;
                }
                goals[firstTeam] += resultFirstTeam;

                if (!goals.ContainsKey(secondTeam))
                {
                    goals[secondTeam] = 0;
                }
                goals[secondTeam] += resultSecondTeam;


                input = Console.ReadLine();
            }

            Console.WriteLine("League standings:");
            var number = 1;
            foreach (var item in points.OrderByDescending(x => x.Value).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{number}. {item.Key} {item.Value}");
                number++;
            }

            var topGoals = goals.OrderByDescending(a => a.Value).ThenBy(y => y.Key).Take(3).ToDictionary(x => x.Key, y => y.Value);
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in topGoals)
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");                
            }
        }
    }
}
