using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_SpyGram
{
    public class _2_SpyGram
    {
        public static void Main()
        {
            var key = Console.ReadLine();   
                     
            var keyArray = new List<int>();

            var result = new SortedDictionary<string, List<string>>();

            foreach (var item in key)
            {
                var digit = item - '0';
                keyArray.Add(digit);               
            }

            var input = Console.ReadLine();
            var regex = @"^TO:\s+([A-Z]+);\s+MESSAGE:\s+(.+);";


            while (input != "END")
            {
                var pattern = new Regex(regex);
                var message = pattern.Match(input);

                if (message.Success)
                {
                    var realMessege = message.Groups[0].Value;
                    var sender = message.Groups[1].Value;
                    var keycode = Keycode(keyArray, realMessege.Length);

                    var encriptedMessege = "";

                    for (int i = 0; i < realMessege.Length; i++)
                    {
                        var temp = realMessege[i] + keycode[i];
                        encriptedMessege += (char)temp;                       
                    }

                    if (!result.ContainsKey(sender))
                    {
                        result[sender] = new List<string>();
                    }

                    result[sender].Add(encriptedMessege);
                }

                input = Console.ReadLine();
            }

            foreach (var item in result)
            {
                var final = item.Value;

                foreach (var item1 in final)
                {
                    Console.WriteLine(item1);
                }
               
            }

        }

        private static List<int> Keycode(List<int> keyArray, int count)
        {
            var keycode = new List<int>();

            while(keycode.Count < count)
            {
                keycode.AddRange(keyArray);
            }

            return keycode;
        }
    }
}
