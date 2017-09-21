using System;
using System.Linq;

namespace _04_Special_Words
{
    public class _04_Special_Words
    {
        public static void Main()
        {

            var specialWords = Console.ReadLine().Split();
            var separator = new[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' };

            var text = Console.ReadLine().TrimEnd('.').Split(separator, StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < specialWords.Length; i++)
            {
                var count = 0;
                var currentWord = specialWords[i];

                for (int j = 0; j < text.Length; j++)
                {
                    if (currentWord == text[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{currentWord} - {count}");
            }
        }
    }
}
