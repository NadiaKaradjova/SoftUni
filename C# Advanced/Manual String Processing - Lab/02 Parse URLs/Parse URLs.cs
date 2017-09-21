using System;
using System.Linq;

namespace _02_Parse_URLs
{
    public class _02_Parse_URLs
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { "://" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (input.Length != 2 || !input[1].Contains('/'))
            {
                Console.WriteLine("Invalid URL");
                return;
            }

            var protocol = input[0];
            var index = input[1].IndexOf('/');
            var server = input[1].Substring(0, index);
            var resources = input[1].Substring(index + 1);
            
            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resources}");
        }
    }
}
