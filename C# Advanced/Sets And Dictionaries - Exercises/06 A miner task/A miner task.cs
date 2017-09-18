using System;
using System.Collections.Generic;

namespace _06_A_miner_task
{
    public class _06_A_miner_task
    {
        public static void Main()
        {
            var result = new Dictionary<string, long>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var resource = input;
                var quantity = long.Parse(Console.ReadLine());

                if (!result.ContainsKey(resource))
                {
                    result[resource] = 0;
                }
                result[resource] += quantity;

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
