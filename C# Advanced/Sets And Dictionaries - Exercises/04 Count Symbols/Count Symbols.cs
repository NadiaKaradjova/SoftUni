using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Count_Symbols
{
    public class _04_Count_Symbols
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new SortedDictionary<char, int>();

            foreach (var item in input)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }
                result[item] += 1;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }

        }
    }
}
