using System;
using System.Collections.Generic;
using System.Linq;

namespace _14_Dragon_Army

{
    public class _14_Dragon_Army
    {
        public static void Main()
        {
            var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
            var n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var color = input[0];
                var name = input[1];
                
                int damage = 0;
                int health = 0;
                int armor = 0;

                if (!int.TryParse(input[2], out damage))
                {
                    damage = 45;
                }
                if (!int.TryParse(input[3], out health))
                {
                    health = 250;
                }
                if (!int.TryParse(input[4], out armor))
                {
                    armor = 10;
                }

                if (!dragons.ContainsKey(color))
                {
                    dragons[color] = new SortedDictionary<string, int[]>();
                }

                dragons[color][name] = new int[] { damage, health, armor };
               
            }

            foreach (var color in dragons)
            {
                var colorType = color.Key;
                var dragonNames = color.Value;

                var damageAv = dragonNames.Values.Average(x => x[0]);
                var healthAv = dragonNames.Values.Average(x => x[1]);
                var armorAv = dragonNames.Values.Average(x => x[2]);

                Console.WriteLine($"{colorType}::({damageAv:f2}/{healthAv:f2}/{armorAv:f2})");
                foreach (var dragon in dragonNames)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }

            }
        }
    }
}

