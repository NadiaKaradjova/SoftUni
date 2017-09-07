using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task1
{
    public class task1
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var result = regex.Matches(text);
           

            foreach (Match item in result)
            {
                Console.Write(item.Value + " ");
            }
            
            Console.WriteLine();
        }
    }
}
