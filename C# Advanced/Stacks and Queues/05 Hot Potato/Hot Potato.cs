using System;
using System.Collections.Generic;

namespace _05_Hot_Potato
{
    public class _05_Hot_Potato
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());

            var leftKids = new Queue<string>(children);

            while (leftKids.Count > 1)
            {
                for (int i = 0; i < number-1; i++)
                {
                    leftKids.Enqueue(leftKids.Dequeue());
                }
                Console.WriteLine($"Removed {leftKids.Dequeue()}");
            }
            Console.WriteLine($"Last is {leftKids.Peek()}");
        }
    }
}
