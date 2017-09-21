using System;
using System.Text.RegularExpressions;

namespace _01_Match_Count
{
    public class _01_Match_Count
    {
        public static void Main()
        {
            var pattern = new Regex(Console.ReadLine());
            var text = Console.ReadLine();

            var matches = pattern.Matches(text);
            Console.WriteLine(matches.Count);
        }
    }
}
