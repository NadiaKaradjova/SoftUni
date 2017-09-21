using System;
using System.Linq;

namespace _12_Character_Multiplier
{
    public class _12_Character_Multiplier
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var firstWord = words[0];
            var secondWord = words[1];
            var length = Math.Min(firstWord.Length, secondWord.Length);

            var sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }
            if (firstWord.Length < secondWord.Length)
            {
                sum += SubString(firstWord, secondWord);
            }
            else if (firstWord.Length > secondWord.Length)
            {
                sum += SubString(secondWord, firstWord);
            }

            Console.WriteLine(sum);
        }

        private static int SubString(string firstWord, string secondWord)
        {
            var sum = 0;
            var temp = secondWord.Substring(firstWord.Length);
            foreach (var item in temp)
            {
                sum += item;
            }
            return sum;
        }
    }
}
