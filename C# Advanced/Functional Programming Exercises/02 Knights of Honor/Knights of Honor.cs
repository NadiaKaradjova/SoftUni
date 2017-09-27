using System;

namespace _02_Knights_of_Honor
{
    public class _02_Knights_of_Honor
    {
        public static void Main()
        {
            //Action<string> print = p => Console.WriteLine(p);
            Action<string> addPrefixAndPrint = p => Console.WriteLine("Sir "+ p);

            var text = Console.ReadLine().Split();
            Print(text, addPrefixAndPrint);
        }

        private static void Print(string[] text, Action<string> print)
        {
            foreach (var item in text)
            {
                print(item);
            }
        }
    }
}
