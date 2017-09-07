using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_Endurance_Rally
{
    public class Problem_3_Endurance_Rally
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToArray();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpoints = Console.ReadLine().Split().Select(long.Parse).ToArray();

            double fuel = 0;
            var currentIndex = 0;

            for (int letter = 0; letter < names.Length; letter++)
            {
                fuel = (int)names[letter].First();

                for (int i = 0; i < zones.Length; i++)
                {
                    var currentFuel = zones[i];
                    currentIndex = i;

                    if (checkpoints.Contains(i))
                    {
                        fuel += currentFuel;
                    }
                    else
                    {
                        fuel -= currentFuel;
                    }

                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{names[letter]} - reached {i}");                    
                        break;
                    }
                    
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{names[letter]} - fuel left {fuel:f2}");
                }

            }            

        }
    }
}
