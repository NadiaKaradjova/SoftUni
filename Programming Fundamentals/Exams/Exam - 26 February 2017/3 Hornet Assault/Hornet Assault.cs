using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Hornet_Assault
{
    public class _3_Hornet_Assault
    {
        public static void Main()
        {
            var beeHives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();


            for (int i = 0; i < beeHives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                var powerHornet = hornets.Sum();

                if (powerHornet <= beeHives[i])
                {
                    beeHives[i] -= powerHornet;
                    hornets.RemoveAt(0);
                }
                else
                {
                    beeHives[i] = 0;
                }
            }


            if (beeHives.Any(x => x > 0))
            {
                Console.WriteLine(string.Join(" ", beeHives.Where(x => x > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
