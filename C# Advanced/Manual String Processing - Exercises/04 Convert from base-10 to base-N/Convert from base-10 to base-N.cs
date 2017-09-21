using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04_Convert_from_base_10_to_base_N
{
    public class _04_Convert_from_base_10_to_base_N
    {
        public static void Main()
        {
            var arg = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var number = BigInteger.Parse( arg[1]);
            var baseN = int.Parse(arg[0]);
            var result = new Stack<BigInteger>();

            while (number > 0)
            {
                var rest = number % baseN;
                result.Push(rest);
                number = number / baseN;
            }

            while (result.Count != 0)
            {
                Console.Write(result.Pop());
            }
            Console.WriteLine();
        }
    }
}
