using System;

namespace _02_String_Length
{
    public class _02_String_Length
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            if (text.Length > 20)
            {
                text = text.Substring(0, 20);
            }
            text = text.PadRight(20, '*');
            Console.WriteLine(text);
        }
    }
}
