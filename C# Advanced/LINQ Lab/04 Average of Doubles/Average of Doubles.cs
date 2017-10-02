using System;
using System.Linq;

namespace _04_Average_of_Doubles
{
    public class _04_Average_of_Doubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Console.WriteLine($"{numbers.Average():f2}");
        }
    }
}
