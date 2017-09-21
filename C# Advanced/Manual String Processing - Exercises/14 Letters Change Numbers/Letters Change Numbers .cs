using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _14_Letters_Change_Numbers
{
    public class _14_Letters_Change_Numbers
    {
        public static void Main()
        {
            var pattern = new Regex(@"\d+");

            var words = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            decimal result = 0;

            foreach (var word in words)
            {
                var digits = pattern.Match(word);
                var number = int.Parse(digits.Groups[0].Value);
                result += Calculation(word, number);
            }

            Console.WriteLine($"{result:f2}");
        }

        private static decimal Calculation(string word, int number)
        {
            var separator = number.ToString();
            var alfabet = "abcdefghijklmnopqrstuvwxyz";
            var alfabetUpper = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            var firstLetter = word.First();
            var secondLetter = word.Last();


            decimal result = 0;
            var index = 0;
            if (Char.IsLower(firstLetter))
            {
                index = alfabet.IndexOf(firstLetter) + 1;
                result += number * (decimal)index;
            }
            else
            {
                index = alfabetUpper.IndexOf(firstLetter) + 1;
                result += number / (decimal)index;
            }


            if (Char.IsLower(secondLetter))
            {
                index = alfabet.IndexOf(secondLetter) + 1;
                result += (decimal)index;
            }
            else
            {
                index = alfabetUpper.IndexOf(secondLetter) + 1;
                result -= (decimal)index;
            }
            return result;
        }
    }
}
