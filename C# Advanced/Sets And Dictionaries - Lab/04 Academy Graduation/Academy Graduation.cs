using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Academy_Graduation
{
    public class _04_Academy_Graduation
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                var grades = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                var averageScore = grades.Average();

                result.Add(name, averageScore);
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} is graduated with {item.Value}");
            }
        }
    }
}
