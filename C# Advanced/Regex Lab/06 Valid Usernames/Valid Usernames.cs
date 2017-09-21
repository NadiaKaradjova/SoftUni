using System;
using System.Text.RegularExpressions;

namespace _06_Valid_Usernames
{
    public class _06_Valid_Usernames
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = new Regex(@"^[\w-]{3,16}$");

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
