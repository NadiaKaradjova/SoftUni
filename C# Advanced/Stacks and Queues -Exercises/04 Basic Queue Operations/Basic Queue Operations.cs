using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Basic_Queue_Operations
{
    public class _04_Basic_Queue_Operations
    {
        public static void Main()
        {
            var inputCommand = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            var numbers = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < inputCommand[0]; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < inputCommand[1]; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(inputCommand[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
