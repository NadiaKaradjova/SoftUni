using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Find_Evens_or_Odds
{
    public class _04_Find_Evens_or_Odds
    {
        public static void Main()
        {
            var borders = Console.ReadLine().Split().Select(int.Parse).ToArray();
                   
            var command = Console.ReadLine();

            var numbers = Enumerable.Range(borders[0], borders[1] - borders[0]+1).ToArray();

            Predicate<int> isEven = n => n % 2 == 0;

            Print(numbers, command, isEven);
        }

        private static void Print(IEnumerable<int> numbers, string command, Predicate<int> isEven)
        {
            foreach (var item in numbers)
            {
                if (command == "even" && isEven(item))
                {
                    Console.Write(item + " ");
                }
                else if (command == "odd" && !isEven(item))
                {
                    Console.Write(item + " ");
                }                
            }
            Console.WriteLine();
        }
    }
}
