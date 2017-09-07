using System;
using System.Collections.Generic;
using System.Linq;


namespace task11_Dragon_Army
{
    public class task11_Dragon_Army
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
           
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();                     

            for (int i = 0; i < n; i++)
            {
                
                var input = Console.ReadLine().Split(' ').ToArray();

                var gragonAtr = input.Skip(2).ToArray();
                string dragonAtrubutes = string.Join(" ", gragonAtr);

                var color = input[0];
                var name = input[1];
                decimal damage, health, armor;

                if (!decimal.TryParse(input[2], out damage))
                damage = 45m;
                
                if(!decimal.TryParse(input[3], out health))
                health = 250m;
                
                if(!decimal.TryParse(input[4], out armor))
                armor = 10m;

                if (!dragons.ContainsKey(color))
                {
                    dragons[color] = new SortedDictionary<string, decimal[]>();
                }
                
                dragons[color][name] = new decimal[] { damage, health, armor };                
            }


            foreach (var color in dragons)
            {
                var colorName = color.Key;
                var dragonsByColor = color.Value;

                var averageDamage = dragonsByColor.Values.Average(a => a[0]);
                var averageHealth = dragonsByColor.Values.Average(a => a[1]);
                var averageArmor = dragonsByColor.Values.Average(a => a[2]);
                
                Console.WriteLine($"{colorName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var name in dragonsByColor)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
     }
}
