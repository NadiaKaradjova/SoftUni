using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Sets_of_Elements
{
    public class _02_Sets_of_Elements
    {
        public static void Main()
        {
            var inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstList = new HashSet<int>();
            var final = new HashSet<int>();

            for (int i = 0; i < inputNumbers[0]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                firstList.Add(number);
            }
            for (int i = 0; i < inputNumbers[1]; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (firstList.Contains(number))
                {
                    final.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", final));
        }
    }
}
