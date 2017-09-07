using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3_Camera_View
{
    public class task3_Camera_View
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var text = Console.ReadLine();

            var m = numbers[0];
            var n = numbers[1];

            var patern = new Regex(@"[|][<](\w+)");
            var result = patern.Matches(text).Cast<Match>().Select(x => x.Value).ToArray();
            
            var newList = new List<string>();

            foreach (var item in result)
            {
                var proba = item.Remove(0, m+2);
                if (proba.Length>n)
                {
                    var x = proba.Remove(n, proba.Length-n);
                    newList.Add(x);
                }
                else newList.Add(proba);          
                
            }

            Console.WriteLine(string.Join (", ", newList));

        }
    }
}
