using System;
using System.Linq;

namespace _07_Predicate_for_names
{
    public class _07_Predicate_for_names
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();

            foreach (var name in names.Where(x => x.Length <= n))
            {
                Console.WriteLine(name);
            }            
        }
    }
}
