using System;
using System.Text.RegularExpressions;

namespace _06_Sentence_Extractor
{
    public class _06_Sentence_Extractor
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();
           
            var pattern = new Regex($@"[A-Za-z0-9 ]+\b{key}\bs*.*?[.!?]");

            var matches = pattern.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
