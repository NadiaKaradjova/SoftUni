using System;
using System.Linq;

namespace _02_Sum_Numbers
{
    public class _02_Sum_Numbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine();
            Func<string, int> Parser = n => int.Parse(n);

            Console.WriteLine(numbers.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(Parser)
              .Count());

            Console.WriteLine(numbers.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(Parser)
               .Sum());
        }
    }
}
