using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task5_Match_Numbers
{
    public class task5_Match_Numbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regix = new Regex(@"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))");

            var result = regix.Matches(text);

            foreach (Match item in result)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();

        }
    }
}
