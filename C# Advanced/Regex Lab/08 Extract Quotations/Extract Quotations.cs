using System;
using System.Text.RegularExpressions;

namespace _08_Extract_Quotations
{
    public class _08_Extract_Quotations
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            
            var pattern = new Regex("('|\")(.+?)\\1");

            var matches = pattern.Matches(input);
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups[2].Value);
            }

        }
    }
}
