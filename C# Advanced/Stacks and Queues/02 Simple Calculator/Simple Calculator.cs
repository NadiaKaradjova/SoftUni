using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Simple_Calculator
{
    public class _02_Simple_Calculator
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            var resultStack = new Stack<string>(input.Reverse());

           while (resultStack.Count > 1)
           {
                var firstNumber = int.Parse(resultStack.Pop());
                var operatorSign = resultStack.Pop();
                var secondNumber = int.Parse(resultStack.Pop());
                

                if (operatorSign == "+")
                {
                    resultStack.Push((firstNumber + secondNumber).ToString());
                }
                else if (operatorSign == "-")
                {
                    resultStack.Push((firstNumber - secondNumber).ToString());
                }              
               
            }
            Console.WriteLine(resultStack.Peek());
        }
    }
}
