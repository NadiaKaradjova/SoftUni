using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Count_Same_Values_in_Array
{
    public class _03_Count_Same_Values_in_Array
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            var result = new SortedDictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ContainsKey(input[i]))
                {
                    result[input[i]] = 0;
                }
                result[input[i]] += 1;
            }


            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }

        }
    }
}
