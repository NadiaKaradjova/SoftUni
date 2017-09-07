using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task2_Match_phone_number
{
    public class task2_Match_phone_number
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\s*\+359(-| )2\1\d{3}\1\d{4}\b");
            var result = regex.Matches(text).Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            
            
           Console.WriteLine(string.Join(", ", result));
        }
    }
}
