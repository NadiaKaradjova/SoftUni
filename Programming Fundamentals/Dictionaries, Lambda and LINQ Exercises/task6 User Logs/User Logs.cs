using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_User_Logs
{
    public class task6_User_Logs
    {
        public static void Main()
        {
            var nameLog = new SortedDictionary<string, Dictionary<string, int>>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var part = line.Split(' ');

                var tempIP = part[0].Length;
                var tempName = part[2].Length;

                var numberIP = part[0].Substring(3, tempIP - 3);
                var userName = part[2].Substring(5, tempName - 5);


                if (!nameLog.ContainsKey(userName))
                {
                    nameLog[userName] = new Dictionary<string, int>();

                }
                var ipLog = nameLog[userName];

                int count = 1;

                if (!ipLog.ContainsKey(numberIP))
                {
                    ipLog[numberIP] = count;
                }
                else ipLog[numberIP] += count;


                line = Console.ReadLine();

            }

            foreach (var item in nameLog)
            {
                var name = item.Key;
                Console.WriteLine($"{name}:");
                var ipNumber = item.Value;
                var newList = new List<string>();

                foreach (var ip in ipNumber)
                {
                    var newString = string.Join(", ", $"{ip.Key} => {ip.Value}");

                    newList.Add(newString);

                }

                Console.WriteLine(string.Join(", ", newList) + ".");
            }

        }
    }
}
