using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Poke_Mon
{
    public class Problem1_Poke_Mon
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            var temp = n*0.5;

            while (n >= m && m > 0 & n > 0)
            {
                n = n - m;
                count++;

                if ((double)n == temp)
                {
                    if ((y > 0 && y < 10) && n>y)
                    {
                        n = n / y;
                    }
                }                 
            }                      
            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
