using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3_Match_Hexadecimal_Numbers
{
    public class task3_Match_Hexadecimal_Numbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\b(?:0x)?[0-9A-F]+\b");
            var result = regex.Matches(text).Cast<Match>().Select(a=>a.Value).ToArray();
            
           Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
