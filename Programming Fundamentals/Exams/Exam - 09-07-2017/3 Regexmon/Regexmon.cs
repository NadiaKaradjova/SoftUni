using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3_Regexmon
{
    public class _3_Regexmon
    {
        public static void Main()
        {
            var didiPokemon = @"[^A-Za-z-]+";
            var bojoPokemon = @"[A-Za-z]+-[A-Za-z]+";

            var input = Console.ReadLine();
            
            var result = new List<string>();
            
            var didiPattern = new Regex(didiPokemon);
            var bojoPattern = new Regex(bojoPokemon);

            while (true)
            {
                var didi = didiPattern.Match(input);

                if (didi.Success)
                {
                    result.Add(didi.Value);
                    var indexEnd = input.IndexOf(didi.Value) + didi.Value.Length;
                    input = input.Remove(0, indexEnd);
                }
                else
                {
                    break;
                }

                var bojo = bojoPattern.Match(input);

                if (bojo.Success)
                {
                    result.Add(bojo.Value);
                    var indexEnd = input.IndexOf(bojo.Value) + bojo.Value.Length;
                    input = input.Remove(0, indexEnd);
                }
                else
                {
                    break;                
                }
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }            
        }


        
    }
}
