using System;
using System.Collections.Generic;

namespace _01_Unique_Usernames
{
    public class _01_Unique_Usernames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var name = Console.ReadLine();
                result.Add(name);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
