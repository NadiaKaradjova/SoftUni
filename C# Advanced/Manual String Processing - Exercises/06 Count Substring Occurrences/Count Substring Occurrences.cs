using System;

namespace _06_Count_Substring_Occurrences
{
    public class _06_Count_Substring_Occurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var key = Console.ReadLine();

            var index = 0;
            var count = 0;

            while (text.IndexOf(key, StringComparison.OrdinalIgnoreCase) != -1)
            {
                count++;
                index = text.IndexOf(key, StringComparison.OrdinalIgnoreCase);
                text = text.Substring(index+1);
            }
            Console.WriteLine(count);
        }
    }
}
