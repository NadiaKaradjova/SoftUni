using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9_Legendary_Farming
{
    public class task9_Legendary_Farming
    {
        public static void Main()
        {
            string line = "";
            for (int i = 0; i < 10; i++)
            {
                var input = Console.ReadLine();
                line = line + " " + input;
            }

            var newline = line.ToLower().Split(' ').ToArray();

            var lineLen = newline.Length;
            var materials = new Dictionary<string, int>();
            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            var otherMaterials = new SortedDictionary<string, int>();


            var winner = 0;
            for (int i = 1; i <= lineLen; i+=2)
            {
                var quantity = int.Parse(newline[i]);
                var name = newline[i + 1];

                if (name == "shards" || name == "fragments" || name== "motes")
                {
                    materials[name] += quantity;
                    
                }
                else
                {
                    if(!otherMaterials.ContainsKey(name))
                    {
                        otherMaterials[name] = quantity;
                    }
                    else
                    {
                        otherMaterials[name] += quantity;
                    }
                }

                foreach (var item in materials)
                {
                    if (item.Value >= 250)
                    {

                        if (item.Key == "shards")
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            materials["shards"] = item.Value - 250;
                            winner = 1;
                            break;
                        }
                        else if (item.Key == "fragments")
                        {
                            Console.WriteLine("Valanyr obtained!");
                            materials["fragments"] = item.Value - 250;
                            winner = 1;
                            break;
                        }
                        else if (item.Key == "motes")
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            materials["motes"] = item.Value - 250;
                            winner = 1;
                            break;
                        }                                       
                    }
                }

                if (winner == 1)
                {
                    break;
                }

            }
                                    
            foreach (var material in materials.OrderByDescending(p => p.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in otherMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");                
            }
        }
    }
}
