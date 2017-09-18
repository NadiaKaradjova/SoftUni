using System;
using System.Collections.Generic;

namespace _02_SoftUni_Party
{
    public class _02_SoftUni_Party
    {
        public static void Main()
        {
            var gestList = new SortedSet<string>();

            var input = Console.ReadLine();

            while (input != "PARTY")
            {
                gestList.Add(input);
                input = Console.ReadLine();
            }

            while (input != "END")
            {
                gestList.Remove(input);
                input = Console.ReadLine();
            }

            Console.WriteLine(gestList.Count);
            foreach (var item in gestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
