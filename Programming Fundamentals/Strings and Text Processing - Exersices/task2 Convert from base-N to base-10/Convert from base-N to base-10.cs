using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace task1_Convert_from_base_10_to_base_N
{
    public class task1_Convert_from_base_10_to_base_N
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var number = BigInteger.Parse(input[1]);
            var n = int.Parse(input[0]);
                        
            var pow = 0;
            BigInteger sum = 0;
            
            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    var temp = (int)(number % 10);
                    BigInteger num = temp * BigInteger.Pow(n, pow);
                    number = number / 10;
                    pow++;
                    sum += num;
                }
            }
           
            Console.WriteLine(sum);
        }
    }
}
