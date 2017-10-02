using System;
using System.Linq;

namespace _07_Bounded_Numbers
{
    public class _07_Bounded_Numbers
    {
        public static void Main()
        {
            var borders = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            
            var numbers = Console.ReadLine().Split().Select(int.Parse).Where(n => n >= borders[0] && n <= borders[1]);
            
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
