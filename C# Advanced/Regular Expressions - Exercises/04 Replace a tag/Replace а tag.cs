using System;
using System.Text.RegularExpressions;

namespace _04_Replace_a_tag
{
    public class _04_Replace_a_tag
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"<a (href=.+?)>(.+)<\/a>");

            while (input != "end")
            {
                var tag = pattern.Match(input);                

                if (tag.Success)
                {
                    input = pattern.Replace(input, "[URL $1]$2[/URL]");   
                    
                }
                Console.WriteLine(input);
                input = Console.ReadLine();
            }
        }
    }
}
