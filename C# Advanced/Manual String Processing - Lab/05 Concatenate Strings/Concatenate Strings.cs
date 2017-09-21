using System;
using System.Text;

namespace _05_Concatenate_Strings
{
    public class _05_Concatenate_Strings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                sb.Append(word).Append(" ");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
        }
    }
}
