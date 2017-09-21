using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05_Extract_Tags
{
    public class _05_Extract_Tags
    {
        public static void Main()
        {            
            var text = Console.ReadLine();
            var pattern = new Regex(@"<.+?>");
            var result = new List<string>();

            while (text != "END")
            {
                var matches = pattern.Matches(text);
                foreach (Match item in matches)
                {
                    result.Add(item.Value);
                }
                text = Console.ReadLine();
            }
            
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
