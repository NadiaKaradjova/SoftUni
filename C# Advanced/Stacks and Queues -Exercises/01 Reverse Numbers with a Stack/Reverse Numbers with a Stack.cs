using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Reverse_Numbers_with_a_Stack
{
    public class _01_Reverse_Numbers_with_a_Stack
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            var reversed = new Stack<int>(numbers);

            Console.WriteLine(string.Join(" ", reversed));
        }
    }
}
