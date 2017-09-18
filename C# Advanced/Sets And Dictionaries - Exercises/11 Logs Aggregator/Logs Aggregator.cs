using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Logs_Aggregator
{
    public class _11_Logs_Aggregator
    {
        public static void Main()
        {
            var counts = new SortedDictionary<string, int>();
            var ips = new Dictionary<string, SortedSet<string>>();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var name = input[1];
                var count = int.Parse(input[2]);
                var ip = input[0];

                if (!counts.ContainsKey(name))
                {
                    counts[name] = 0;
                    ips[name] = new SortedSet<string>();
                }
                counts[name] += count;
                ips[name].Add(ip);
            }

            foreach (var name in counts.OrderBy(x => x.Key))
            {
                Console.Write ($"{name.Key}: {name.Value} ");

                foreach (var item in ips.Where(x => x.Key == name.Key))
                {
                    var listIps = item.Value;
                    Console.WriteLine("[" + string.Join(", ", listIps) + "]");
                }
            }
        }
    }
}
