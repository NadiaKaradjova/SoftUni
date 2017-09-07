using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_Sort_Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count-1)
                Console.Write(numbers[i] + " <= ");
                else
                    Console.WriteLine(numbers[i]);
            }
            
        }
    }
}
