using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var nums = input.Split(' ').Select(int.Parse).ToList();

            int bestIndex = 0;
            int bestLen = 0;
            int currentIndex = 0;
            int currentLen = 1;

            for (int i = 1; i < nums.Count; i++)
            {

                if (nums[i] == nums[i - 1])
                {
                    currentLen++;
                    if (bestLen < currentLen)
                    {
                        bestLen = currentLen;
                        bestIndex = currentIndex;
                    }
                }
                else
                {
                    currentIndex = i;
                    currentLen = 1;
                }
            }

            for (int k = bestIndex; k < bestIndex + bestLen; k++)
            {
                Console.Write(nums[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
