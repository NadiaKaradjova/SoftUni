using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_Multiply_big_number
{
    public class task7_Multiply_big_number
    {
        public static void Main()
        {
            var num = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            
            var result = new StringBuilder();

            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var temp = MultiplayBigNumbers(num, n);
                temp.Reverse();

                foreach (var item in temp)
                {
                    result.Append(item);
                }
                var finalStr = result.ToString().TrimStart('0');

                Console.WriteLine(finalStr);
            }          
          
        }



        public static List<int> MultiplayBigNumbers(string num, int n)
        {
            var multiplay = 0;
            var buffer = 0;
            var temp = new List<int>();
            

            for (int i = 0; i < num.Length; i++)
            {
                var currentIndex = num.Length - 1 - i;

                multiplay = (num[currentIndex] - '0') * n + buffer;

                if (multiplay >= 10)
                {
                    buffer = multiplay / 10;
                    multiplay = multiplay % 10;
                    temp.Add(multiplay);
                }
                else
                {
                    temp.Add(multiplay);
                    buffer = 0;
                }
            }
            
            temp.Add(buffer);
            return temp;
        }
    }
}
