using System;
using System.Text.RegularExpressions;

namespace _02_Match_Phone_Number
{
    public class _02_Match_Phone_Number
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"^\+359(\s|-)2\1\d{3}\1\d{4}$");

            while (input != "end")
            {
                var match = pattern.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }

                input = Console.ReadLine();
            }
        }
    }
}
