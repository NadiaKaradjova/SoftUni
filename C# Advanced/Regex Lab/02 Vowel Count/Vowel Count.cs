using System;
using System.Text.RegularExpressions;

namespace _02_Vowel_Count
{
    public class _02_Vowel_Count
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = new Regex(@"[AEIOUYaeiouy]");

            var matches = pattern.Matches(text);
            Console.WriteLine($"Vowels: {matches.Count}");
        }
    }
}
