using System;
using System.Collections.Generic;

namespace _03_Decimal_to_Binary_Converter
{
    public class _03_Decimal_to_Binary_Converter
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var binaryNumber = new Stack<int>();

            if (number == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (number != 0)
                {
                    var binaryDigit = number % 2;
                    number /= 2;
                    binaryNumber.Push(binaryDigit);
                }
            }

            var length = binaryNumber.Count;
            for (int i = 0; i < length; i++)
            {
                Console.Write(binaryNumber.Pop());
            }
            Console.WriteLine();
        }
    }
}
