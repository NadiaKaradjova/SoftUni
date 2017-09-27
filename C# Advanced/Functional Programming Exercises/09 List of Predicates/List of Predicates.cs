using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_List_of_Predicates
{
    public class _09_List_of_Predicates
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                        
            Func<int, int, bool> filter = (num, d) => num % d == 0;

            SelectAndPrint(n, dividers, filter);
        }

        private static void SelectAndPrint(int n, int[] dividers, Func<int, int, bool> filter)
        {
            
            var result = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                var isNumber = true;
                foreach (var divider in dividers)
                {
                    if (!filter(i, divider))
                    {
                        isNumber = filter(i, divider);
                        break;
                    }                   
                }
                if (isNumber)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
