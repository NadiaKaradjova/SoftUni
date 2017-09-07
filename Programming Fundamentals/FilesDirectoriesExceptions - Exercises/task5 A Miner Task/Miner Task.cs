using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_A_Miner_Task
{
    public class task5_A_Miner_Task
    {
        public static void Main()
        {
            var minerals = File.ReadLines("input.txt").ToArray();

            var listOfMinerals = new Dictionary<string, int>();

            for (int i = 0; i < minerals.Length-1; i+=2)
            {
                
                if (!listOfMinerals.ContainsKey(minerals[i]))
                {
                    listOfMinerals[minerals[i]] = 0;
                }
                listOfMinerals[minerals[i]] += int.Parse(minerals[i+1]);
            }


            foreach (var item in listOfMinerals)
            {
                File.AppendAllText("output.txt", $"{item.Key} -> {item.Value}{Environment.NewLine}");
            }
        }
    }
}
