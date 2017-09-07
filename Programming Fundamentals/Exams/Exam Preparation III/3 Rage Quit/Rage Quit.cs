using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace _3_Rage_Quit
{
    public class _3_Rage_Quit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();

            var pattern = new Regex(@"(\D+)(\d+)");

            var matches = pattern.Matches(input);

            var newString = new StringBuilder();
            
            foreach (Match item in matches)
            {
                var newStringToAdd = new StringBuilder();
                var count = int.Parse(item.Groups[2].Value);
                var stringNew = item.Groups[1].Value;

                
                for (int i = 0; i < count; i++)
                {
                    newStringToAdd.Append(stringNew);
                }
                newString.Append(newStringToAdd);
            }

            var line = newString.ToString();

            Console.WriteLine($"Unique symbols used: {line.Distinct().Count()}");
            Console.WriteLine(line);
        }
    }
}
