using System;
using System.Text.RegularExpressions;

namespace _07_Valid_Time
{
    public class _07_Valid_Time
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"[01][0-9]:[0-5][\d]:[0-5][\d] (A|P)M");

            while (input != "END")
            {
               
                var match = pattern.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
        }
    }
}
