using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Maximum_Element
{
    public class _03_Maximum_Element
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var maxNumbers = new Stack<int>();
            var maxValue = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray(); 

                if (input[0] == 1)
                {
                    var numberToAdd = input[1];
                    stack.Push(numberToAdd);
                    if (numberToAdd > maxValue)
                    {
                        maxValue = numberToAdd;
                        maxNumbers.Push(maxValue);                        
                    }
                }
                else if (input[0] == 2)
                {                    
                    if (stack.Pop() == maxValue)
                    {
                        maxNumbers.Pop();
                        if (maxNumbers.Count > 0)
                        {
                            maxValue = maxNumbers.Peek();
                        }
                        else
                        {
                            maxValue = int.MinValue;
                        }
                        
                    }                   
                }
                else if (input[0] == 3)
                {
                   Console.WriteLine(maxValue);
                }
            }
        }
    }
}
