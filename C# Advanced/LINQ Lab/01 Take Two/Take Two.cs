using System;
using System.Linq;

namespace _01_Take_Two
{
    public class _01_Take_Two
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var result = numbers.Distinct().Where(x => x >= 10 && x <= 20).Take(2).ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
