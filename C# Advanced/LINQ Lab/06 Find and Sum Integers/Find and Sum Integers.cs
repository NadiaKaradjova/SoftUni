using System;
using System.Linq;

namespace _06_Find_and_Sum_Integers
{
    public class _06_Find_and_Sum_Integers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split()
                .Select(x =>
                {
                    long value;
                    var parsed = Int64.TryParse(x, out value);
                    return new { parsed, value };
                })
                .Where(kvp => kvp.parsed == true)
                .Select(x => x.value)
                .ToList();

            if (input.Count > 0)
            {
                Console.WriteLine(input.Sum());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
