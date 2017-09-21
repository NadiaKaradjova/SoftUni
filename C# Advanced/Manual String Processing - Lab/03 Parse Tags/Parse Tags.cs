using System;

namespace _03_Parse_Tags
{
    public class _03_Parse_Tags
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var patternOpen = "<upcase>";
            var patternClose = "</upcase>";

            while (input.Contains(patternOpen) && input.Contains(patternClose))
            {
                var startIndex = input.IndexOf(patternOpen) + patternOpen.Length;
                var length = input.IndexOf(patternClose) - startIndex;
                var text = input.Substring(startIndex, length);
                input = input.Replace(text, text.ToUpper());

                input = input.Remove(input.IndexOf(patternOpen), patternOpen.Length);
                input = input.Remove(input.IndexOf(patternClose), patternClose.Length);               
            }

            Console.WriteLine(input);
        }
    }
}
