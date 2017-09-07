using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_Split_by_Word_Casing
{
    class Program
    {
        static void Main()
        {
            var separators = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            var words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCaseWords = new List<string>();
            var upperCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();

            foreach (string word in words)
            {
                int lowerCaseCount = 0;
                int upperCaseCount = 0;

                foreach (char letter in word)
                {
                    if (char.IsLower(letter)) lowerCaseCount++;
                    else if (char.IsUpper(letter)) upperCaseCount++;
                }

                if (lowerCaseCount == word.Length)
                {
                    lowerCaseWords.Add(word);
                }
                else if (upperCaseCount == word.Length)
                {
                    upperCaseWords.Add(word);
                }
                else mixedCaseWords.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
