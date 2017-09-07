using System;
using System.Numerics;

namespace task3_Big_Factorial
{
    public class task3_Big_Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = n; i > 1; i--)
            {
                result *= i; 
            }

            Console.WriteLine(result);
        }
    } 
}
