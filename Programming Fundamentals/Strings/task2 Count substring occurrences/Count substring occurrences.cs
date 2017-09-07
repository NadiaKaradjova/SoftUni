using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_Count_substring_occurrences
{
    public class task2_Count_substring_occurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var patern = Console.ReadLine().ToLower();

            var count = 0;
            var index = 0;

            while (true)
            {
                var result = text.IndexOf(patern, index);
                if (result >= 0)
                {
                    count++;
                    index = result + 1;
                }
                else break;                
            }
            Console.WriteLine(count);
        }
       
    }
}
