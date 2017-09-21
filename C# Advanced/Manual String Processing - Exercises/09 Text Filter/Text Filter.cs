using System;
using System.Linq;

namespace _09_Text_Filter
{
    public class _09_Text_Filter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                var currentWord = bannedWords[i];
                text = text.Replace(currentWord, new string('*', currentWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
