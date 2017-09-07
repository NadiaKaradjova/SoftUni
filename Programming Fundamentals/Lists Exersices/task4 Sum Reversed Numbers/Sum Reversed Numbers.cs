using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Sum_Reversed_Numbers
{
    class Program
    {
        static void Main()
        {
            //123 234 12
            var input = Console.ReadLine().Split(' ');

            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                List<char> reversed = input[i].Reverse().ToList();
                var numbers = string.Join("", reversed);
                int parsed = int.Parse(numbers);
                sum += parsed;
            }
            Console.WriteLine(sum);
        }
    }
}
