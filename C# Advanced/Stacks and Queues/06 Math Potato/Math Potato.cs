using System;
using System.Collections.Generic;

namespace _06_Math_Potato
{
    public class _06_Math_Potato
    {
        public static void Main()
        {
            var children = Console.ReadLine().Split();
            var number = int.Parse(Console.ReadLine());

            var leftKids = new Queue<string>(children);
            
            var count = 1;

            while (leftKids.Count > 1)
            {

                for (int i = 0; i < number - 1; i++)
                {
                    leftKids.Enqueue(leftKids.Dequeue());
                }
                
                if (IsPrime(count))
                {
                    Console.WriteLine($"Prime {leftKids.Peek()}");
                }
                else
                {                    
                    Console.WriteLine($"Removed {leftKids.Dequeue()}");
                }
                count++;
            }
            Console.WriteLine($"Last is {leftKids.Peek()}");
        }
        

        public static bool IsPrime(int count)
        {
            if ((count & 1) == 0)
            {
                if (count == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; (i * i) <= count; i += 2)
            {
                if ((count % i) == 0)
                {
                    return false;
                }
            }
            return count != 1;
        }        
    }
}
