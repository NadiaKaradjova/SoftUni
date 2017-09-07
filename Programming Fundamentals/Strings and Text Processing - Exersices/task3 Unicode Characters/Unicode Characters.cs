using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_Unicode_Characters
{
    public class task3_Unicode_Characters
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();

            var sb = new StringBuilder();

            foreach (var item in text)
            {
                var result = "\\u" + ((int)item).ToString("X4");
                sb.Append(result);
            }
            var final = sb.ToString().ToLower();
            Console.WriteLine(final);
        }
    }
}
