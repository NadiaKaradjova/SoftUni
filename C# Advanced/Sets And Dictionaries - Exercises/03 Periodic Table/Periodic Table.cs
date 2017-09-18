using System;
using System.Collections.Generic;

namespace _03_Periodic_Table
{
    public class _03_Periodic_Table
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split();

                for (int j = 0; j < elements.Length; j++)
                {
                    result.Add(elements[j]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
