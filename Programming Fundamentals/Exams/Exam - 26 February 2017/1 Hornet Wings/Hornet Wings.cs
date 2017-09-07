using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Hornet_Wings
{
    public class _1_Hornet_Wings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = int.Parse(Console.ReadLine());

            var distance = n / 1000 * m;
            var seconds = n / p * 5 + n/100;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{seconds} s.");

        }
    }
}
