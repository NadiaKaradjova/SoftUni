using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09_Query_Mess
{
    public class _09_Query_Mess
    {
        public static void Main()
        {
            var input = Console.ReadLine(); 
            var spaces = new Regex(@"(%20)|(\+)");           

            while (input != "END")
            {
                var result = new Dictionary<string, List<string>>();
                var line = input.Split('?');
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i].Contains('='))
                    {
                        var keyValuePairs = line[i].Split('&');

                        foreach (var item in keyValuePairs)
                        {
                            var finalItem = Regex.Replace(item, spaces.ToString(), " ");
                            finalItem = Regex.Replace(finalItem, @"\s+", " ");
                            var keyValuePair = finalItem.Split('=');
                            if (!result.ContainsKey(keyValuePair[0].Trim()))
                            {
                                result[keyValuePair[0].Trim()] = new List<string>();
                            }
                            var keyList = result[keyValuePair[0].Trim()];
                            var keys = keyValuePair[1].Trim();
                            keyList.Add(keys);  
                        }
                    }
                }
                foreach (var item in result)
                {
                    Console.Write($"{item.Key}=[" + string.Join(", ", item.Value) + "]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }            
        }
    }
}
