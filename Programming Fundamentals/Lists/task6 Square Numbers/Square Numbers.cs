using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_Square_Numbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var result = new List<int>();
            
            foreach (var item in numbers)
            {
                if (IsExactSquare(item))
                {
                    result.Add(item);
                }                
            }
            result.Sort();
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }

        public static bool IsExactSquare(int num)
        {
            return Math.Sqrt(num) == (int)Math.Sqrt(num);               
        }
    }
}
