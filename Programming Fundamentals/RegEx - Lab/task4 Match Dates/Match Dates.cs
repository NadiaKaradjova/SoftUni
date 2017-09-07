using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4_Match_Dates
{
    public class task4_Match_Dates
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regix = new Regex(@"\b(\d{2})(\/|-|\.)([A-Z][a-z]{2})\2(\d{4}\b)");

            var result = regix.Matches(text);

            foreach (Match item in result)
            {
                var day = item.Groups[1];
                var mounth = item.Groups[3];
                var year = item.Groups[4];

                Console.WriteLine($"Day: {day}, Month: {mounth}, Year: {year}");
            }
        }
    }
}
