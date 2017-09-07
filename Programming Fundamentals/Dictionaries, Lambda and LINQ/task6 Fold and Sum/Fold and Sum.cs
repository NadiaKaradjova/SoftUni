using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_Fold_and_Sum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = input.Length / 4;

            var fisrtPartLine = input.Take(k).Reverse().ToArray();
            var secondPartLine = input.Reverse().Take(k).ToArray();

            var firstLine = fisrtPartLine.Concat(secondPartLine).ToArray();
            var secondLine = input.Skip(k).Take(2*k).ToArray();
                   

            var sum = firstLine.Select((x, index) => x + secondLine[index]).ToArray();

            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
