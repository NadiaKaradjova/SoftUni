using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_First_Name
{
    public class _03_First_Name
    {
        public static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var letters = Console.ReadLine().ToLower().Split();

            var resultNames = new List<string>();

            foreach (var letter in letters)
            {
               resultNames.AddRange(names.Where(x => x.ToLower().StartsWith(letter)));
            }

            if (resultNames.Count > 0)
            {
                Console.WriteLine(resultNames.Distinct().OrderBy(x => x).First());
            }
            else
            {
                Console.WriteLine("No match");
            }           
        }
    }
}
