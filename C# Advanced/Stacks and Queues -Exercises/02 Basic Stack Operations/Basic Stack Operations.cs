using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_Basic_Stack_Operations
{
    public class _02_Basic_Stack_Operations
    {
        public static void Main()
        {
            var inputCommand = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < inputCommand[0]; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < inputCommand[1]; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(inputCommand[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
