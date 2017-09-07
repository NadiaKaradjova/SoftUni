using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Poke_Mon
{
    public class _1_Poke_Mon
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var count = 0;

            var temp = n;
            while (temp >= m) 
            {
                temp = temp - m;
                count++;

                if ((double)temp == n / 2.0 && (y > 0 && y < 10))
                {
                    temp = temp / y;
                }
            }
            Console.WriteLine(temp);
            Console.WriteLine(count);
        }
    }
}
