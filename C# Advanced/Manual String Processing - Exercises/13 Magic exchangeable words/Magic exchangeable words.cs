using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_Magic_exchangeable_words
{
    public class _13_Magic_exchangeable_words
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var firstWord = words[0];
            var secondWord = words[1];

            var result = new Dictionary<char, char>();
            var isExchangeable = true;

            var length = Math.Min(firstWord.Length, secondWord.Length);

            for (int i = 0; i < length; i++)
            {
                var currentKey = firstWord[i];
                var currentValue = secondWord[i];
                if (!result.ContainsKey(currentKey))
                {
                    if (!result.ContainsValue(currentValue))
                    {
                        result[currentKey] = currentValue;
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (result[currentKey] != currentValue)
                    {
                        isExchangeable = false;
                        break;
                    }
                }         
            }

            var restOfWord = String.Empty;
            if (firstWord.Length < secondWord.Length)
            {
                restOfWord = secondWord.Substring(length);
            }
            else
            {
                restOfWord = firstWord.Substring(length);
            }

            foreach (var letter in restOfWord)
            {
                if (!result.ContainsKey(letter) && !result.ContainsValue(letter))
                {
                    isExchangeable = false;
                    break;
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
