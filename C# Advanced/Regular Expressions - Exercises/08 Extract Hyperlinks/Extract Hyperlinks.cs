using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08_Extract_Hyperlinks
{
    public class _08_Extract_Hyperlinks
    {
        public static void Main()
        {            
            var pattern = new Regex(@"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>");

            var input = Console.ReadLine();

            var text = new StringBuilder();

            while (input != "END")
            {
                text.Append(input).Append(" ");
                input = Console.ReadLine();
            }
            
            var matches = pattern.Matches(text.ToString());

            foreach (Match item in matches)
            {
               var current = item.Groups[1].ToString().Trim();
                
                if (current[0] == '"')
                {
                   Console.WriteLine(current.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else if(current[0] == '\'')
                {
                    Console.WriteLine(current.Split(new[] { '\'' }, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(current, @"\s+").First());
                }
            }
        }
    }
}
