using System;
using System.Linq;

namespace _02_Upper_Strings
{
    public class _02_Upper_Strings
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split().ToList();

            words.Select(x => x.ToUpper()).ToList().ForEach(x => Console.Write(x + " ")); 
        }
    }
}
