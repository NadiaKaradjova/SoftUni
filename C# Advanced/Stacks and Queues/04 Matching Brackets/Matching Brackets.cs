using System;
using System.Collections.Generic;

namespace _04_Matching_Brackets
{
    public class _04_Matching_Brackets
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stackIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stackIndex.Push(i);
                }

                if (input[i] == ')')
                {
                    var length = i - stackIndex.Peek() +1;
                    var substring = input.Substring(stackIndex.Pop(), length);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
