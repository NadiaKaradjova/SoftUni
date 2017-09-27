using System;
using System.Linq;

namespace _03_Count_Uppercase_Words
{
    public class _03_Count_Uppercase_Words
    {
        public static void Main()
        {
            Func<string, bool> IsFirstLeetterIsUpper = n => Char.IsUpper(n[0]);

            var text = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(w => IsFirstLeetterIsUpper(w)).
                ToArray();

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
