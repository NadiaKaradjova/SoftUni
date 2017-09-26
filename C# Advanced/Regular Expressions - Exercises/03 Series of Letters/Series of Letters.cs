using System;
using System.Text.RegularExpressions;

namespace _03_Series_of_Letters
{
    public class _03_Series_of_Letters
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"(.)\1+");
            
            var output = pattern.Replace(input, "$1");

            Console.WriteLine(output);
        }
    }
}
