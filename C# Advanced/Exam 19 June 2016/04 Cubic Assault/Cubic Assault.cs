using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Cubic_Assault
{
    public class _04_Cubic_Assault
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, long>>();

            var input = Console.ReadLine();
            var borderCount = 1000000l;

            while (input != "Count em all")
            {
                var line = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var region = line[0];
                var type = line[1];
                var typeCount = long.Parse(line[2]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new Dictionary<string, long>() { { "Red", 0 }, { "Black", 0 }, { "Green", 0 } };
                }

                if (result[region].ContainsKey(type))
                {
                    result[region][type] += typeCount;
                }

                if (result[region]["Green"] >= borderCount)
                {
                    var temp = result[region]["Green"] / borderCount;
                    result[region]["Green"] %= borderCount;
                    result[region]["Red"] += temp;
                }
                if (result[region]["Red"] >= borderCount)
                {
                    var temp = result[region]["Red"] / borderCount;
                    result[region]["Red"] %= borderCount;
                    result[region]["Black"] += temp;
                }

                input = Console.ReadLine();
            }
            var final = result.OrderByDescending(x => x.Value["Black"]).ThenBy(x => x.Key.Length).ThenBy(x => x.Key);

            foreach (var region in final)
            {
                Console.WriteLine(region.Key);

                foreach (var type in region.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"-> {type.Key} : {type.Value}");
                }
            }
        }
    }
}