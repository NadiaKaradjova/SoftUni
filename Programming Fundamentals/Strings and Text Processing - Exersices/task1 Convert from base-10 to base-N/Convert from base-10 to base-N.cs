using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace task1_Convert_from_base_10_to_base_N
{
    public class task1_Convert_from_base_10_to_base_N
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var number = BigInteger.Parse(input[1]);
            var n = int.Parse(input[0]);

            var finalNumber = new List<int>();

            if (number == 0 && n != 0)
            {
                finalNumber.Add((int)(number % n));
            }

            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    finalNumber.Add((int)(number % n));
                    number = number / n;
                }
            }


            finalNumber.Reverse();

            Console.WriteLine(string.Join("", finalNumber));

        }
    }
}