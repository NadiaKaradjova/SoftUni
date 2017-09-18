using System;
using System.Collections.Generic;

namespace _08_Recursive_Fibonacci
{
    public class _08_Recursive_Fibonacci
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var resultStack = new Stack<long>();

            resultStack.Push(0);
            resultStack.Push(1);

            for (int i = 2; i < n+1; i++)
            {
                var previousNumber = resultStack.Pop();                
                var result = resultStack.Peek() + previousNumber;                
                resultStack.Push(previousNumber);
                resultStack.Push(result);
            }

            Console.WriteLine(resultStack.Peek());
        }
    }
}


