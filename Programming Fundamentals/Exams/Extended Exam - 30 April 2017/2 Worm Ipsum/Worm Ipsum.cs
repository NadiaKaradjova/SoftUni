using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_Worm_Ipsum
{
    public class _2_Worm_Ipsum
    {
        public static void Main()
        {
            var pattern = new Regex(@"([A-Z].*?[.])");            

            var input = Console.ReadLine();

            while (input != "Worm Ipsum")
            {
                var line = pattern.Matches(input);

                if (line.Count == 1)
                {
                    var validLine = pattern.Match(input).Value.TrimEnd('.');
                    var words = validLine.Split().ToArray();

                    var newLine = "";

                    foreach (var word in words)
                    {
                        var newWord = ConvertLetters(word);
                        newLine += newWord + " ";
                    }
                    Console.WriteLine($"{newLine.Trim()}.");
                }
                input = Console.ReadLine();
            }           
            
        }

        private static string ConvertLetters(string word)
        {
            var wordWithSigh = word;

            if (word.EndsWith(","))
            {
                word = word.TrimEnd(',');
            }

            var count = 0;
            char letter = char.MinValue;
            var newWord = "";

            for (int i = 0; i < word.Length; i++)
            {
                var symbol = word[i];
                var currentCount = 0;

                for (int j = 0; j < word.Length; j++)
                {
                    if (symbol == word[j])
                    {
                        currentCount++;
                    }
                }
                if (currentCount > count)
                {
                    count = currentCount;
                    letter = symbol;
                }
            }
            
            if (count > 1)
            {
                newWord = new string(letter, word.Length);
                if (wordWithSigh.EndsWith(","))
                {
                    newWord += ',';
                }
            }
            else
            {
                newWord = word;
                if (wordWithSigh.EndsWith(","))
                {
                    newWord += ',';
                }
            }
            return newWord;
        }
    }
}
