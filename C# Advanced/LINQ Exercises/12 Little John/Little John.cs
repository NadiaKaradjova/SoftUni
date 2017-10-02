using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_Little_John
{
    public class _12_Little_John
    {
        public static void Main()
        {
            var arrows = new List<string>();

            var bigArrow = ">>>----->>";
            var middleArrow = ">>----->";
            var smallArrow = ">----->";

            var pattern = new Regex(@"\>+\-{5}\>+");

            for (int i = 0; i < 4; i++)
            {
                var input = Console.ReadLine();
                var matches = pattern.Matches(input);
                foreach (Match match in matches)
                {
                    arrows.Add(match.Value);                 
                }
            }

            var bigArrowCount = 0;
            var middleArrowCount = 0;
            var smallArrowCount = 0;

            foreach (var item in arrows)
            {
                if (item.Contains(bigArrow))
                {
                    bigArrowCount++;
                }
                else if (item.Contains(middleArrow))
                {
                    middleArrowCount++;
                }
                else if (item.Contains(smallArrow))
                {
                    smallArrowCount++;
                }
            }
           
            var finalString = smallArrowCount.ToString() + middleArrowCount.ToString() + bigArrowCount.ToString();
            
            var binary = Convert.ToString(int.Parse(finalString), 2);            
            
           var reversed = binary.ToString().ToArray();
           Array.Reverse(reversed);
           foreach (var symbol in reversed)
           {
                binary += symbol;
           }

           var dec = Convert.ToInt64(binary, 2);
           Console.WriteLine(dec);             
        }
    }
}
