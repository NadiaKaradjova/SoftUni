using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Count_Numbers
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = nums.Count;

            //input.Sort();
            
            var count = new int[nums.Max() + 1];

            foreach (var num in nums)
            {
                count[num]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, count[i]);
                }
            }
        }
    }
}
