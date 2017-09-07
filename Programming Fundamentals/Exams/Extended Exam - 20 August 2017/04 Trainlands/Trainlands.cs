using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04_Trainlands
{
    public class _04_Trainlands
    {
        public static void Main()
        {
            var patternTrain = new Regex(@"^([^\s-:>=]+)\s->\s([^\s-:>=]+)\s:\s(\d+)$");
            var patternCommandMove = new Regex(@"^([^\s-:>=]+)\s->\s([^\s-:>=]+)$");
            var patternCommandEquals = new Regex(@"^([^\s-:>=]+)\s=\s([^\s-:>=]+)$");

            var result = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();

            while (input != "It's Training Men!")
            {
                var train = patternTrain.Match(input);

                if (train.Success)
                {
                    var trainName = train.Groups[1].Value;
                    var wagonName = train.Groups[2].Value;
                    var wagonPower = long.Parse(train.Groups[3].Value);

                    if (!result.ContainsKey(trainName))
                    {
                        result[trainName] = new Dictionary<string, long>();
                    }
                    result[trainName].Add(wagonName, wagonPower);
                }

                var commandMove = patternCommandMove.Match(input);
                if (commandMove.Success)
                {
                    var fisrtTrainName = commandMove.Groups[1].Value;
                    var secondTrainName = commandMove.Groups[2].Value;

                    if (!result.ContainsKey(fisrtTrainName))
                    {
                        result[fisrtTrainName] = new Dictionary<string, long>();
                    }
                    foreach (var item in result[secondTrainName])
                    {
                        result[fisrtTrainName].Add(item.Key, item.Value);
                    }
                    result.Remove(secondTrainName);
                }

                var commandEquals = patternCommandEquals.Match(input);

                if (commandEquals.Success)
                {
                    var fisrtTrainName = commandEquals.Groups[1].Value;
                    var secondTrainName = commandEquals.Groups[2].Value;

                    if (!result.ContainsKey(fisrtTrainName))
                    {
                        result[fisrtTrainName] = new Dictionary<string, long>();
                    }
                    else
                    {
                        result[fisrtTrainName].Clear();
                    }
                    foreach (var item in result[secondTrainName])
                    {
                        result[fisrtTrainName].Add(item.Key, item.Value);
                    }
                }

                input = Console.ReadLine();
            }

            
            var final = result.OrderByDescending(x => x.Value.Values.Sum()).ThenByDescending(y => y.Value.Count).ToDictionary(a => a.Key, b => b.Value);

            foreach (var train in final)
            {
                Console.WriteLine($"Train: {train.Key}");
                var wagons = train.Value;
                foreach (var wagon in wagons.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
