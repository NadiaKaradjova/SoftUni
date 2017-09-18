using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Balanced_Parentheses
{
    public class _07_Balanced_Parentheses
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var openBrackets = new char[] { '[', '(', '{' };
            var closeBrackets = new char[] { ']', ')', '}' };

            var queue = new Queue<char>(input);
            var openBracketsStack = new Stack<char>();

            foreach (var bracket in input)
            {
                if (openBrackets.Contains(bracket))
                {
                    openBracketsStack.Push(queue.Dequeue());
                }
                else if (closeBrackets.Contains(bracket) && openBracketsStack.Count > 0)
                {
                    var open = openBracketsStack.Peek();
                    var close = queue.Peek();
                    if ((open == '{' && close == '}') || (open == '[' && close == ']') || (open == '(' && close == ')'))
                    {
                        openBracketsStack.Pop();
                        queue.Dequeue();
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (openBracketsStack.Count == 0 && queue.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
