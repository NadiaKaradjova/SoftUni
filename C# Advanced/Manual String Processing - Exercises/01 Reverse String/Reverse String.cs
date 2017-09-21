using System;

namespace _01_Reverse_String
{
    public class _01_Reverse_String
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToCharArray();
            Array.Reverse(text);
            Console.WriteLine(text);
        }
    }
}
