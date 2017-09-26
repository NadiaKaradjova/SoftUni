using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_Valid_Usernames
{
    public class _07_Valid_Usernames
    {
        public static void Main()
        {

            string[] validNames = Console.ReadLine()
                .Split(' ', '/', '\\', '(', ')')
                .Where(u => Regex.IsMatch(u, @"\b([A-Za-z]\w{2,24})\b"))
                .ToArray();
                 
            
            var sum = 0;
            var first = "";
            var second = "";

            for (int j = 0; j < validNames.Length-1; j++)
            {
                var temp = validNames[j].Length + validNames[j + 1].Length;
                if (sum < temp)
                {
                    sum = temp;
                    first = validNames[j];
                    second = validNames[j + 1];
                }
            }
            Console.WriteLine(first);
            Console.WriteLine(second);
        }
    }
}
