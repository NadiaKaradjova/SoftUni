using System;
using System.Linq;

namespace _06_Reverse_and_exclude
{
    public class _06_Reverse_and_exclude
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbers.Reverse();
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Join(" ", numbers.Where(x => x % n != 0)));
        }
    }
}
