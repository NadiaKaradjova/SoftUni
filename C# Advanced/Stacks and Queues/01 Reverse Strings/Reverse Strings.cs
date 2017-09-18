using System;
using System.Collections.Generic;


namespace _01_Reverse_Strings
{
    public class _01_Reverse_Strings
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var reversedStack = new Stack<char>();

            foreach (var item in input)
            {
                reversedStack.Push(item);
            }

            Console.WriteLine(string.Join("", reversedStack));
        }
    }
}
