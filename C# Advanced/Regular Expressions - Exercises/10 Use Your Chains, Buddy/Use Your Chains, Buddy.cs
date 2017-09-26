using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _10_Use_Your_Chains__Buddy
{
    public class _10_Use_Your_Chains__Buddy
    {
        public static void Main()
        {
            var pattern = new Regex(@"<p>(.*?)<\/p>");
            var patternForReplace = new Regex(@"[^a-z0-9]");
            var alphabetFirst = "abcdefghijklm";
            var alphabetSecond = "nopqrstuvwxyz";

            var input = Console.ReadLine();
            var words = pattern.Matches(input);

            var finalText = new StringBuilder();

            foreach (Match item in words)
            {
                var text = item.Groups[1].Value;
                text = patternForReplace.Replace(text, " ");

                foreach (var symbol in text)
                {
                    if (alphabetFirst.Contains(symbol))
                    {
                        var index = alphabetFirst.IndexOf(symbol);
                        finalText.Append(alphabetSecond[index]);
                    }
                    else if (alphabetSecond.Contains(symbol))
                    {
                        var index = alphabetSecond.IndexOf(symbol);
                        finalText.Append(alphabetFirst[index]);
                    }
                    else
                    {
                        finalText.Append(symbol);
                    }
                }                      
            }

            var result = Regex.Replace(finalText.ToString(), @"\s+", @" ");
            Console.WriteLine(result);
        }
    }
}
