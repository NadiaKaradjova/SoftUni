using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Poisonous_Plants
{
    public class _11_Poisonous_Plants
    {
        public static void Main()
        {
            var plantsNumber = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine().Split().Select(int.Parse).ToArray();
          
            var daysPlantDie = new int[plantsNumber];

            var previousPlant = new Stack<int>();
            previousPlant.Push(0);

            for (int i = 1; i < plantsNumber; i++)
            {
                int lastDay = 0;
                while (previousPlant.Count() > 0 && plants[previousPlant.Peek()] >= plants[i])
                {
                    lastDay = Math.Max(lastDay, daysPlantDie[previousPlant.Pop()]);
                }

                if (previousPlant.Count() > 0)
                {
                    daysPlantDie[i] = lastDay + 1;
                }
                
                previousPlant.Push(i);
            }
            
            Console.WriteLine(daysPlantDie.Max());
        }
    }
}
