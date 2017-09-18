using System;
using System.Collections.Generic;


namespace _05_Calculate_Sequence_with_Queue
{
    public class _05_Calculate_Sequence_with_Queue
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            var sequenceNumbers = new Queue<long>();
            
            sequenceNumbers.Enqueue(number);
            
            for (int i = 0; i < 50; i++)
            {
                var currentNumber = sequenceNumbers.Dequeue();
                Console.Write(currentNumber + " ");
                sequenceNumbers.Enqueue(currentNumber + 1);
                sequenceNumbers.Enqueue(2 * currentNumber + 1);
                sequenceNumbers.Enqueue(currentNumber + 2); 
            }
        }
    }
}
