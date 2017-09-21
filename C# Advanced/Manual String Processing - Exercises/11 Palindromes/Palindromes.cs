using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Palindromes
{
    public class _11_Palindromes
    {
        public static void Main()
        {
            var separator = new[] { '.', '!', '?', ',', ' ' };
            var text = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var result = new SortedSet<string>();

            foreach (var word in text)
            {
                var length = word.Length / 2;
                var reminder = word.Length % 2;
                var firstPart = word.Substring(0, length);
                var second = word.Substring(length+reminder).ToCharArray();
                Array.Reverse(second);
                var secondPart = string.Join("", second);
                if (firstPart.Equals(secondPart))
                {
                    result.Add(word);
                }
            }

            Console.WriteLine("[" + string.Join(", ", result) +  "]");           
        }
    }
}
