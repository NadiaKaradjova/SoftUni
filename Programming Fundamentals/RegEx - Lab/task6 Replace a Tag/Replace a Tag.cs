using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task6_Replace_a_Tag
{
    public class task6_Replace_a_Tag
    {
        public static void Main()
        {
            var regex = new Regex(@"<a.*href=(""|')(.*)\1>(.*?)<\/a>");
            
            var text = Console.ReadLine();

            while (text != "end")
            {
                var result = regex.Replace(text, @"[URL href=""$2""]$3[/URL]");
                Console.WriteLine(result);
                text = Console.ReadLine();
            }              
        }
    }
}
