using System;

namespace _10_Unicode_Characters
{
    public class _10_Unicode_Characters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            foreach (var letter in input)
            {
                Console.Write("\\u" + ((int)letter).ToString("x4"));
            }
            Console.WriteLine();
        }
    }
}
