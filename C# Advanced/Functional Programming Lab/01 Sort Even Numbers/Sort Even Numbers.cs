using System;
using System.Linq;

namespace _01_Sort_Even_Numbers
{
    public class _01_Sort_Even_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(n => n % 2 == 0)
                .OrderBy(n => n)
                .ToArray();

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
