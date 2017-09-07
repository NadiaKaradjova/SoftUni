using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task2_Extract_sentences_by_keyword
{
    public class task2_Extract_sentences_by_keyword
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var input = Console.ReadLine().Split('.', '!', '?').ToArray();

            var newword = $@"\b{word}\b";
            Regex pattern = new Regex(newword);

            foreach (var sentence in input)
            {                
                if (pattern.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }           
            }
        }
    }
}
