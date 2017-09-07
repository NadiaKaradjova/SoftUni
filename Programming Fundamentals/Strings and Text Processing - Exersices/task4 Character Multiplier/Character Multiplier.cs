using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Character_Multiplier
{
    public class task4_Character_Multiplier
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split();
            var firstStr = text[0];
            var secondStr = text[1];

            Console.WriteLine(Multiplier(firstStr, secondStr));

        }

        public static int Multiplier(string str1, string str2)
        {
            var sum = 0;
            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    var temp = str1[i] * str2[i];
                    sum += temp;
                }
            }
            else if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    var temp = str1[i] * str2[i];
                    sum += temp;
                }
                str2 = str2.Remove(0, str1.Length);
                foreach (var item in str2)
                {
                    sum += item;
                }
            }

            else if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    var temp = str1[i] * str2[i];
                    sum += temp;
                }
                str1 = str1.Remove(0, str2.Length);
                foreach (var item in str1)
                {
                    sum += item;
                }
            }

            return sum;
        }
    }
}
