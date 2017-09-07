using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Wormtes
{
    public class _01_Wormtes
    {
        public static void Main()
        {

            var lengthInMeters = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var length = lengthInMeters * 100.0;

            var remainder = length % width;

            if (remainder == 0 || width == 0)
            {
                Console.WriteLine($"{length*width:f2}");
            }
            else
            {
                Console.WriteLine($"{length / width*100:f2}%");
            }
        }
    }
}
