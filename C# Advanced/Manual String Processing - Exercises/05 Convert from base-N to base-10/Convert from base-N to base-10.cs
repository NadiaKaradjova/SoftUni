using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _05_Convert_from_base_N_to_base_10
{
    public class _05_Convert_from_base_N_to_base_10
    {
        public static void Main()
        {
            var arg = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var number = arg[1];
            var baseN = int.Parse(arg[0]);
            var result = new Stack<int>();

            for (int i = 0; i < number.Length; i++)
            {
                var digit = number[i] - '0';
                result.Push(digit);
            }
            var power = 0;
            BigInteger sum = 0;
            while (result.Count != 0)
            {
                sum += result.Pop() * BigInteger.Pow(baseN, power);
                power++;
            }

            Console.WriteLine(sum);
        }
    }
}
