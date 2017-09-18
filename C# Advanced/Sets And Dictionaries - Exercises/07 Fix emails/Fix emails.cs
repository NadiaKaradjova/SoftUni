using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_Fix_emails
{
    public class _07_Fix_emails
    {
        public static void Main()
        {
            var book = new Dictionary<string, string>();

            var input = Console.ReadLine();

            while (input != "stop")
            {
                var name = input;
                var email = Console.ReadLine();

                if (!book.ContainsKey(name))
                {
                    book[name] = "";
                }
                book[name] = email;

                input = Console.ReadLine();
            }

            var result = book.Where(x => x.Value.EndsWith(".uk") || x.Value.EndsWith(".us"));

            foreach (var item in book)
            {
                if (!result.Contains(item))
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
                
            }
        }
    }
}
