using System;
using System.Text.RegularExpressions;

namespace _11_Semantic_HTML
{
    public class _11_Semantic_HTML
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var patternOpening = new Regex(@"<div([^>]+.*?)(?:id|class)\s*=\s*""([a-z]+)""(.*?)\s*>");
            var patternClosing = new Regex(@"<\/div>\s*<!--\s*([a-z]+)\s*-->");

            while (text != "END")
            {
                var matchOpening = patternOpening.Match(text);
                if (matchOpening.Success)
                {
                    text = Regex.Replace(text, patternOpening.ToString(), @"$2 $1 $3");                    
                    text = Regex.Replace(text, @"\s+", @" ").Trim();
                    text = "<" + text + ">";
                }

                var matchClosing = patternClosing.Match(text);
                if (matchClosing.Success)
                {
                    text = Regex.Replace(text, patternClosing.ToString(), @"</$1>");                   
                }
                Console.WriteLine(text);
                text = Console.ReadLine();
            } 
        } 
    }
}
