using System;
using System.Text.RegularExpressions;

namespace _05_Extract_Emails
{
    public class _05_Extract_Emails
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"\s([A-Za-z][\w\.-]+)@(([\w-]+)[.]([\w-]+)([.\w-]+)*)\b");

            var matches = pattern.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
