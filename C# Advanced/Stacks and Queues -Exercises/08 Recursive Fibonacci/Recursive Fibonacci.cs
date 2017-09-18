﻿using System;
using System.Collections.Generic;


namespace _08_Recursive_Fibonacci
{
    public class _08_Recursive_Fibonacci
    {
        public static long[] fibNumbers;

        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());

            fibNumbers = new long[n];

            var result = GetFibonachi(n);
            Console.WriteLine(result);
           
        }

        private static long GetFibonachi(long n)
        {
            if (n <= 2)
            {
                return 1;   
            }

            if (fibNumbers[n - 1] != 0)
            {
                return fibNumbers[n - 1];
            }

           return fibNumbers[n-1] = GetFibonachi(n - 1) + GetFibonachi(n - 2);            
            
        }
    }
}
