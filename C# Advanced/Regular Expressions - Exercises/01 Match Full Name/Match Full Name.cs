using System;
using System.Text.RegularExpressions;

namespace _01_Match_Full_Name
{
    public class _01_Match_Full_Name
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b");

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
