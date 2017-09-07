using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_Short_Words_Sorted
{
    class Program
    {
        static void Main()
        {
            var separator = new []{ '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };
            var input = Console.ReadLine().ToLower().Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

            var result = input                
                .Where(n => n.Length<5)
                .OrderBy(n => n)
                .Distinct()
                .ToList(); 

            Console.WriteLine(string.Join(", ", result));           
        }
    }
}
