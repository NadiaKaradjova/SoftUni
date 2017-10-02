using System;
using System.Linq;

namespace _05_Min_Even_Number
{
    public class _05_Min_Even_Number
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            var result = numbers.Where(x => x % 2 == 0).ToList();

            if (result.Count > 0)
            {
                Console.WriteLine($"{result.Min():f2}");
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
