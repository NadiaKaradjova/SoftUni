using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_A_Miner_Task
{
    public class task3_A_Miner_Task
    {
        public static void Main()
        {
            var resourceCollected = new Dictionary<string, int>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (!resourceCollected.ContainsKey(name))
                {
                    resourceCollected[name] = quantity;
                }
                else
                {
                    resourceCollected[name] += quantity;
                }
            }

            foreach (var item in resourceCollected)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}
