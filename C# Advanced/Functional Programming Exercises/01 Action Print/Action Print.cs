using System;

namespace _01_Action_Print
{
    public class _01_Action_Print
    {
        public static void Main()
        {
            Action<string[]> print = p => Console.WriteLine(string.Join("\n", p));
           
            var text = Console.ReadLine().Split();
            print(text);
        }
    }
}
