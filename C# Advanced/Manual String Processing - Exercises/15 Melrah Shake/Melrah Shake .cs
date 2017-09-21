using System;
using System.Text.RegularExpressions;

namespace _15_Melrah_Shake
{
    public class _15_Melrah_Shake
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var key = Console.ReadLine();

            while (key.Length > 0)
            {
                var pattern = Regex.Escape(key);
                var match = Regex.Matches(text, pattern);

                if (match.Count > 1)
                {
                    text = text.Remove(text.LastIndexOf(key), key.Length);
                    text = text.Remove(text.IndexOf(key), key.Length);
                    Console.WriteLine("Shaked it.");
                    var indexForRemove = key.Length / 2;
                    key = key.Remove(indexForRemove, 1);
                }
                else
                {                    
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}