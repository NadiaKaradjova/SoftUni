using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Wormhole
{
    public class _3_Wormhole
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != 0)
                {
                    var temp = input[i];                     
                    input[i] = 0;
                    i = temp;
                    count++;
                }
                else
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
