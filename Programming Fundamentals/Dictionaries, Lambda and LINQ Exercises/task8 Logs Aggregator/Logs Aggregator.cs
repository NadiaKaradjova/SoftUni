using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8_Logs_Aggregator
{
    public class task8_Logs_Aggregator
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var nameLog = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();
                var ip = line[0];
                var name = line[1];
                var duration = int.Parse(line[2]);

                if (!nameLog.ContainsKey(name))
                {
                    nameLog[name] = new Dictionary<string, int>();
                }
                var ipLog = nameLog[name];

                if (!ipLog.ContainsKey(ip))
                {
                    ipLog[ip] = duration;
                }
                else
                {
                    ipLog[ip] += duration;
                }
            }

            foreach (var item in nameLog)
            {
                Console.Write($"{item.Key}: ");
                var ipList = item.Value.OrderBy(p => p.Key).ToDictionary(p =>p.Key, p =>p.Value);

                Console.Write($"{ipList.Values.Sum()} ");


                var newList = new List<string>();

                foreach (var ip in ipList)
                {
                    newList.Add(ip.Key);

                }
                Console.Write("[");
                Console.WriteLine(string.Join(", ", newList) + "]");
            }
        }
    }
}
