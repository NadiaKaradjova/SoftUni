using System;
using System.Text.RegularExpressions;

namespace _03_Non_Digit_Count
{
    public class _03_Non_Digit_Count
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = new Regex(@"[^\d]");

            var matches = pattern.Matches(text);
            Console.WriteLine($"Non-digits: {matches.Count}");
        }
    }
}
