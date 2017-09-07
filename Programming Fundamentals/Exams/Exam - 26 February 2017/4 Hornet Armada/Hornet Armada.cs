using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_Hornet_Armada
{
    public class _4_Hornet_Armada
    {
        public static void Main()
        {
           
            var legionsWithSoldiers = new Dictionary<string, Dictionary<string, long>>();
            var legionsWithActivity = new Dictionary<string, int>();

            var n = int.Parse(Console.ReadLine());

            var inputPattern = @"^(\d+)\s=\s([^=->:\s]+)\s->\s([^=->:\s]+):(\d+)$";
            var pattern = new Regex(inputPattern);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var line = pattern.Match(input);

                var currentActivity = int.Parse(line.Groups[1].Value);
                var currentName = line.Groups[2].Value;
                var currentType = line.Groups[3].Value;
                var currentCount = long.Parse(line.Groups[4].Value);

                if (!legionsWithActivity.ContainsKey(currentName))
                {
                    legionsWithSoldiers.Add(currentName, new Dictionary<string, long>());
                    legionsWithActivity.Add(currentName, currentActivity);
                }

                if (legionsWithActivity[currentName] < currentActivity)
                {
                    legionsWithActivity[currentName] = currentActivity;
                }

                if (!legionsWithSoldiers[currentName].ContainsKey(currentType))
                {
                    legionsWithSoldiers[currentName].Add(currentType, 0);
                }
                legionsWithSoldiers[currentName][currentType] += currentCount;

            }

            var command = Console.ReadLine().Split('\\').ToArray();

            if (command.Length > 1)
            {
                var count = int.Parse(command[0]);
                var type = command[1];

                foreach (var legionEntry in legionsWithSoldiers
                    .Where(legion => legion.Value.ContainsKey(type))
                    .OrderByDescending(legion => legion.Value[type]))
                {
                    if (legionsWithActivity[legionEntry.Key] < count)
                    {
                        Console.WriteLine("{0} -> {1}", legionEntry.Key, legionsWithSoldiers[legionEntry.Key][type]);
                    }
                }
            }
            else
            {                
                var type = command[0];

                foreach (var legionEntry in legionsWithActivity.OrderByDescending(legion => legion.Value))
                {

                    if (legionsWithSoldiers[legionEntry.Key].ContainsKey(type))
                    {
                        Console.WriteLine("{0} : {1}", legionEntry.Value, legionEntry.Key);
                    }
                }
            }
        }
    }

    
}
