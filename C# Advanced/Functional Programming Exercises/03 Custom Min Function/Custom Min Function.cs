using System;
using System.Linq;

namespace _03_Custom_Min_Function
{
    public class _03_Custom_Min_Function
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> minNumber = x => x.Min();
                       
            Console.WriteLine(minNumber(numbers));
        }
    }
}
