using System;
using System.Text.RegularExpressions;

namespace _04_Extract_Integer_Numbers
{
    public class _04_Extract_Integer_Numbers
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = new Regex(@"\d+");

            var matches = pattern.Matches(text);

            foreach (Match item in matches)
            {
                Console.WriteLine(item);
            }            
        }
    }
}
