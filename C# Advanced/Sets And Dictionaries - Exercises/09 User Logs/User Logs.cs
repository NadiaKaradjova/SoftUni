using System;
using System.Collections.Generic;

namespace _09_User_Logs
{
    public class _09_User_Logs
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var line = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var user = line[2].Substring(5);
                var ip = line[0].Substring(3);

                if (!result.ContainsKey(user))
                {
                    result[user] = new Dictionary<string, int>();
                }
                var ips = result[user];
                if (!ips.ContainsKey(ip))
                {
                    ips[ip] = 0;
                }
                ips[ip] +=1;

                input = Console.ReadLine();
            }

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key}:");
                var addresses = user.Value;
                var list = new List<string>();
                foreach (var ip in addresses)
                {
                    var validIP = $"{ip.Key} => {ip.Value}";
                    list.Add(validIP);
                }
                Console.Write(string.Join(", ", list));
                Console.WriteLine('.');
            }
        }
    }
}
