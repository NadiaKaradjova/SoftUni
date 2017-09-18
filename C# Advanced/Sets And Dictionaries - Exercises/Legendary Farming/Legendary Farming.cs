using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    public class Legendary_Farming
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int> {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };
            var junkItems = new Dictionary<string, int>();

            var input = Console.ReadLine();
            var hasWinner = false;

            while(!hasWinner)
            {
                var line = input.ToLower().Split();

                for (int i = 0; i < line.Length; i += 2)
                {
                    var quantity = int.Parse(line[i]);
                    var item = line[i + 1];
                    

                    if (keyMaterials.ContainsKey(item))
                    {
                        keyMaterials[item] += quantity;
                    }
                    else
                    {
                        if (!junkItems.ContainsKey(item))
                        {
                            junkItems[item] = 0;
                        }
                        junkItems[item] += quantity;
                    }

                    if (keyMaterials.Any(x => x.Value >= 250))
                    {
                        var winner = keyMaterials.First(x => x.Value >= 250);
                        if (winner.Key == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                        }
                        else if (winner.Key == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                        }
                        else if (winner.Key == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                        }
                        keyMaterials[winner.Key] -= 250;
                        hasWinner = true;
                        break;
                    }
                }
                if (!hasWinner)
                {
                    input = Console.ReadLine();
                }
               
            }

            foreach (var material in keyMaterials.OrderByDescending(x => x.Value).ThenBy(y => y.Key)) 
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var item in junkItems.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
