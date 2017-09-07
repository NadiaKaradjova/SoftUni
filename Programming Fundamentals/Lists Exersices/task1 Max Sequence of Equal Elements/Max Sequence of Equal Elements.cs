using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int bestCount = 0;
            int count = 1;
            int bestIndex = 0;
            int index = 0;

            var longest = new List<int>();
            var current = new List<int>();

            // 3 4 4 5 5 5 2 2

            current.Add(nums[0]);

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == current[0])
                {
                    current.Add(nums[i]);
                }
                else
                {
                    if (longest.Count < current.Count)
                    {
                        longest.Clear();
                        longest.AddRange(current);                        
                    }
                    current.Clear();
                    current.Add(nums[i]);
                }

                if (longest.Count < current.Count)
                {
                    longest.Clear();
                    longest.AddRange(current);
                }
                
            }
            Console.WriteLine(string.Join(" ", longest));

        }
    }
}
